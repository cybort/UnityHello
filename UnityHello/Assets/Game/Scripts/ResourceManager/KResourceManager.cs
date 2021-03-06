﻿using UnityEngine;
using System.Collections;
using System;
using System.IO;
using Object = UnityEngine.Object;
using LuaInterface;

namespace KEngine
{
    /// <summary>
    /// 资源路径优先级，优先使用
    /// </summary>
    public enum KResourcePathPriorityType
    {
        Invalid,
        /// <summary>
        /// 忽略PersitentDataPath, 优先寻找Resources或StreamingAssets路径 (取决于ResourcePathType)
        /// </summary>
        InAppPathPriority,
        /// <summary>
        /// 尝试在Persistent目錄尋找，找不到再去StreamingAssets,
        /// 这一般用于进行热更新版本号判断后，设置成该属性
        /// </summary>
        PersistentDataPathPriority,
    }

    public class KResourceManager : Manager
    {
        public enum LoadingLogLevel
        {
            None,
            ShowTime,
            ShowDetail,
        }

        public delegate void AsyncLoadABAssetDelegate(Object asset, object[] args);


        public static bool LoadByQueue = false;
        public static int LogLevel = (int)LoadingLogLevel.None;

        public static string BuildPlatformName
        {
            get { return GetBuildPlatformName(); }
        } // ex: IOS, Android, AndroidLD

        public static string FileProtocol
        {
            get { return GetFileProtocol(); }
        } // for WWW...with file:///xxx

        /// <summary>
        /// Product Folder's Relative Path   -  Default: ../Product,   which means Assets/../Product
        /// </summary>
        public static string ProductRelPath
        {
            get
            {
                return EngineConfig.instance.ProductRelPath;
            }
        }

        /// <summary>
        /// Product Folder Full Path , Default: C:\xxxxx\xxxx\../Product
        /// </summary>
        public static string EditorProductFullPath
        {
            get { return Path.GetFullPath(ProductRelPath); }
        }

        /// <summary>
        /// StreamingAssetsPath/Bundles/Android/ etc.
        /// WWW的读取，是需要Protocol前缀的
        /// </summary>
        public static string BundlesPathWithProtocol { get; private set; }
        public static string BundlesPathWithoutFileProtocol { get; private set; }
        /// <summary>
        /// Bundles/Android/ etc... no prefix for streamingAssets
        /// </summary>
        public static string BundlesPathRelative { get; private set; }
        public static string ApplicationPath { get; private set; }

        public static string BundlesDirName
        {
            get
            {
                return "Bundles";
            }
        }

        /// <summary>
        /// Unity Editor load AssetBundle directly from the Asset Bundle Path,
        /// whth file:// protocol
        /// </summary>
        public static string EditorAssetBundleFullPath
        {
            get
            {
                return "Product/Bundles";
            }
        }

        /// <summary>
        /// check file exists of streamingAssets. On Android will use plugin to do that.
        /// </summary>
        /// <param name="path">relative path,  when file is "file:///android_asset/test.txt", the pat is "test.txt"</param>
        /// <returns></returns>
        public static bool IsStreamingAssetsExists(string path)
        {
            if (Application.platform == RuntimePlatform.Android)
                return KEngineAndroidPlugin.IsAssetExists(path);

            var fullPath = Path.Combine(Application.streamingAssetsPath, path);
            return File.Exists(fullPath);
        }

        public static void LogRequest(string resType, string resPath)
        {
            if (LogLevel < (int)LoadingLogLevel.ShowDetail)
                return;
            Log.Info("[Request] {0}, {1}", resType, resPath);
        }

        public static void LogLoadTime(string resType, string resPath, System.DateTime begin)
        {
            if (LogLevel < (int)LoadingLogLevel.ShowTime)
                return;
            Log.Info("[Load] {0}, {1}, {2}s", resType, resPath, (System.DateTime.Now - begin).TotalSeconds);
        }

        /// <summary>
        /// Load file from streamingAssets. On Android will use plugin to do that.
        /// </summary>
        /// <param name="path">relative path,  when file is "file:///android_asset/test.txt", the pat is "test.txt"</param>
        /// <returns></returns>
        public static byte[] LoadSyncFromStreamingAssets(string path)
        {
            if (!IsStreamingAssetsExists(path))
                throw new Exception("Not exist StreamingAssets path: " + path);

            if (Application.platform == RuntimePlatform.Android)
                return KEngineAndroidPlugin.GetAssetBytes(path);

            var fullPath = Path.Combine(Application.streamingAssetsPath, path);
            return File.ReadAllBytes(fullPath);
        }

        /// <summary>
        /// load asset bundle immediatly
        /// </summary>
        /// <param name="path"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        public static AbstractResourceLoader LoadBundle(string path, AssetFileLoader.AssetFileBridgeDelegate callback = null)
        {
            var request = AssetFileLoader.Load(path, callback, LoaderMode.Sync);
            return request;
        }

        /// <summary>
        /// Load Async Asset Bundle
        /// </summary>
        /// <param name="path"></param>
        /// <param name="callback">cps style async</param>
        /// <returns></returns>
        public static AbstractResourceLoader LoadBundleAsync(string path, AssetFileLoader.AssetFileBridgeDelegate callback = null)
        {
            var request = AssetFileLoader.Load(path, callback);
            return request;
        }

        public static void Collect()
        {
            Resources.UnloadUnusedAssets();
            System.GC.Collect();
        }

        public static string DocumentResourcesPathWithoutFileProtocol
        {
            get
            {
                return string.Format("{0}/{1}/{2}/", GetAppDataPath(), BundlesDirName, BuildPlatformName); // 各平台通用
            }
        }

        public static string DocumentResourcesPath;
        /// <summary>
        /// 是否優先找下載的資源?還是app本身資源優先. 优先下载的资源，即采用热更新的资源
        /// </summary>
        public static KResourcePathPriorityType ResourcePathPriorityType =
            KResourcePathPriorityType.PersistentDataPathPriority;

        public static System.Func<string, string> CustomGetResourcesPath; // 自定义资源路径。。。

        /// <summary>
        /// 统一在字符串后加上.box, 取决于配置的AssetBundle后缀
        /// </summary>
        /// <param name="path"></param>
        /// <param name="formats"></param>
        /// <returns></returns>
        public static string GetAssetBundlePath(string path, params object[] formats)
        {
            var tmpFormat = StringBuilderCache.GetStringAndRelease(StringBuilderCache.Acquire().Append(path).Append(EngineConfig.instance.ABExtName));
            return StringBuilderCache.GetStringAndRelease(StringBuilderCache.Acquire().AppendFormat(tmpFormat, formats));
        }

        // 检查资源是否存在
        public static bool ContainsResourceUrl(string resourceUrl)
        {
            string fullPath;
            return GetResourceFullPath(resourceUrl, false, out fullPath, false) != GetResourceFullPathType.Invalid;
        }

        /// <summary>
        /// 完整路径，www加载
        /// </summary>
        /// <param name="url"></param>
        /// <param name="inAppPathType"></param>
        /// <param name="withFileProtocol">是否带有file://前缀</param>
        /// <param name="isLog"></param>
        /// <returns></returns>
        public static string GetResourceFullPath(string url, bool withFileProtocol = true, bool isLog = true)
        {
            string fullPath;
            if (GetResourceFullPath(url, withFileProtocol, out fullPath, isLog) != GetResourceFullPathType.Invalid)
                return fullPath;

            return null;
        }

        /// <summary>
        /// 用于GetResourceFullPath函数，返回的类型判断
        /// </summary>
        public enum GetResourceFullPathType
        {
            Invalid,
            InApp,
            InDocument,
        }

        /// <summary>
        /// 根据相对路径，获取到StreamingAssets完整路径，或Resources中的路径
        /// </summary>
        /// <param name="url"></param>
        /// <param name="fullPath"></param>
        /// <param name="inAppPathType"></param>
        /// <param name="isLog"></param>
        /// <returns></returns>
        public static GetResourceFullPathType GetResourceFullPath(string url, bool withFileProtocol, out string fullPath,
            bool isLog = true)
        {
            if (string.IsNullOrEmpty(url))
            {
                Log.Error("尝试获取一个空的资源路径！");
            }

            string docUrl;
            bool hasDocUrl = TryGetDocumentResourceUrl(url, withFileProtocol, out docUrl);
            string inAppUrl;
            bool hasInAppUrl;
            hasInAppUrl = TryGetInAppStreamingUrl(url, withFileProtocol, out inAppUrl);
            if (ResourcePathPriorityType == KResourcePathPriorityType.PersistentDataPathPriority) // 優先下載資源模式
            {
                if (hasDocUrl)
                {
                    if (Application.isEditor)
                        Log.Warning("[Use PersistentDataPath] {0}", docUrl);
                    fullPath = docUrl;
                    return GetResourceFullPathType.InDocument;
                }
                // 優先下載資源，但又沒有下載資源文件！使用本地資源目錄 
            }

            if (!hasInAppUrl) // 连本地资源都没有，直接失败吧 ？？ 沒有本地資源但又遠程資源？竟然！!?
            {
                if (isLog)
                    Log.Error("[Not Found] StreamingAssetsPath Url Resource: {0}", url);
                fullPath = null;
                return GetResourceFullPathType.Invalid;
            }
            fullPath = inAppUrl; // 直接使用本地資源！
            return GetResourceFullPathType.InApp;
        }

        private void Awake()
        {
            InitResourcePath();
        }

        private void InitResourcePath()
        {
            BundlesPathRelative = string.Format("{0}/{1}/", BundlesDirName, BuildPlatformName);
            DocumentResourcesPath = FileProtocol + DocumentResourcesPathWithoutFileProtocol;

            switch (Application.platform)
            {
                case RuntimePlatform.WindowsEditor:
                case RuntimePlatform.OSXEditor:
                    {
                        ApplicationPath = string.Format("{0}{1}/", FileProtocol, EditorProductFullPath);
                        BundlesPathWithProtocol = FileProtocol + EditorAssetBundleFullPath + "/" + BuildPlatformName + "/";
                        BundlesPathWithoutFileProtocol = EditorAssetBundleFullPath + "/" + BuildPlatformName + "/";
                    }
                    break;
                case RuntimePlatform.WindowsPlayer:
                case RuntimePlatform.OSXPlayer:
                    {
                        string path = Application.streamingAssetsPath.Replace('\\', '/');//Application.dataPath.Replace('\\', '/');
                        //                        path = path.Substring(0, path.LastIndexOf('/') + 1);
                        ApplicationPath = string.Format("{0}{1}/", FileProtocol, Application.dataPath);
                        BundlesPathWithProtocol = string.Format("{0}{1}/{2}/{3}/", FileProtocol, path, BundlesDirName,
                            BuildPlatformName);
                        BundlesPathWithoutFileProtocol = string.Format("{0}/{1}/{2}/", path, BundlesDirName,
                            BuildPlatformName);
                    }
                    break;
                case RuntimePlatform.Android:
                    {
                        ApplicationPath = string.Concat("jar:", FileProtocol, Application.dataPath,
                            string.Format("!/assets/{0}/", BundlesDirName));
                        BundlesPathWithProtocol = string.Concat(ApplicationPath, BuildPlatformName, "/");
                        BundlesPathWithoutFileProtocol = string.Concat(Application.dataPath,
                            "!/assets/" + BundlesDirName + "/", GetBuildPlatformName() + "/");
                        // 注意，StramingAsset在Android平台中，是在壓縮的apk里，不做文件檢查
                        // Resources folder
                    }
                    break;
                case RuntimePlatform.IPhonePlayer:
                    {
                        ApplicationPath =
                            System.Uri.EscapeUriString(FileProtocol + Application.streamingAssetsPath + "/" +
                                                       BundlesDirName + "/"); // MacOSX下，带空格的文件夹，空格字符需要转义成%20
                        BundlesPathWithProtocol = string.Format("{0}{1}/", ApplicationPath, BuildPlatformName);
                        // only iPhone need to Escape the fucking Url!!! other platform works without it!!! Keng Die!
                        BundlesPathWithoutFileProtocol = Application.streamingAssetsPath + "/" + BundlesDirName + "/" +
                                                                   BuildPlatformName + "/";
                        // Resources folder
                    }
                    break;
                default:
                    {
                        Debuger.Assert(false);
                    }
                    break;
            }
        }

        private static string _editorUserBuildSettingsBuildTarget;
        /// <summary>
        /// UnityEditor.EditorUserBuildSettings.activeBuildTarget, Can Run in any platform~
        /// </summary>
        public static string UnityEditor_EditorUserBuildSettings_activeBuildTarget
        {
            get
            {
                if (Application.isPlaying
                    && !string.IsNullOrEmpty(_editorUserBuildSettingsBuildTarget))
                {
                    return _editorUserBuildSettingsBuildTarget;
                }

                var assemblies = System.AppDomain.CurrentDomain.GetAssemblies();
                foreach (var a in assemblies)
                {
                    if (a.GetName().Name == "UnityEditor")
                    {
                        Type lockType = a.GetType("UnityEditor.EditorUserBuildSettings");
                        //var retObj = lockType.GetMethod(staticMethodName,
                        //    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public)
                        //    .Invoke(null, args);
                        //return retObj;
                        var p = lockType.GetProperty("activeBuildTarget");

                        var em = p.GetGetMethod().Invoke(null, new object[] { }).ToString();
                        _editorUserBuildSettingsBuildTarget = em;
                        return em;
                    }
                }
                return null;
            }
        }

        /// <summary>
        /// Different platform's assetBundles is incompatible.
        /// CosmosEngine put different platform's assetBundles in different folder.
        /// Here, get Platform name that represent the AssetBundles Folder.
        /// </summary>
        /// <returns>Platform folder Name</returns>
        public static string GetBuildPlatformName()
        {
            string buildPlatformName = "Windows"; // default

            if (Application.isEditor)
            {
                var buildTarget = UnityEditor_EditorUserBuildSettings_activeBuildTarget;
                //UnityEditor.EditorUserBuildSettings.activeBuildTarget;
                switch (buildTarget)
                {
                    case "StandaloneOSXIntel":
                    case "StandaloneOSXIntel64":
                    case "StandaloneOSXUniversal":
                        buildPlatformName = "MacOS";
                        break;
                    case "StandaloneWindows": // UnityEditor.BuildTarget.StandaloneWindows:
                    case "StandaloneWindows64": // UnityEditor.BuildTarget.StandaloneWindows64:
                        buildPlatformName = "Windows";
                        break;
                    case "Android": // UnityEditor.BuildTarget.Android:
                        buildPlatformName = "Android";
                        break;
                    case "iPhone": // UnityEditor.BuildTarget.iPhone:
                    case "iOS":
                        buildPlatformName = "iOS";
                        break;
                    default:
                        Debuger.Assert(false);
                        break;
                }
            }
            else
            {
                switch (Application.platform)
                {
                    case RuntimePlatform.OSXPlayer:
                        buildPlatformName = "MacOS";
                        break;
                    case RuntimePlatform.Android:
                        buildPlatformName = "Android";
                        break;
                    case RuntimePlatform.IPhonePlayer:
                        buildPlatformName = "iOS";
                        break;
                    case RuntimePlatform.WindowsPlayer:
#if !UNITY_5_4_OR_NEWER
                    case RuntimePlatform.WindowsWebPlayer:
#endif
                        buildPlatformName = "Windows";
                        break;
                    default:
                        Debuger.Assert(false);
                        break;
                }
            }
            return buildPlatformName;
        }

        /// <summary>
        /// On Windows, file protocol has a strange rule that has one more slash
        /// </summary>
        /// <returns>string, file protocol string</returns>
        public static string GetFileProtocol()
        {
            string fileProtocol = "file://";
            if (Application.platform == RuntimePlatform.WindowsEditor ||
                Application.platform == RuntimePlatform.WindowsPlayer
#if !UNITY_5_4_OR_NEWER
                || Application.platform == RuntimePlatform.WindowsWebPlayer
#endif
)
                fileProtocol = "file:///";

            return fileProtocol;
        }

        /// <summary>
        /// 可被WWW读取的Resource路径
        /// </summary>
        /// <param name="url"></param>
        /// <param name="withFileProtocol">是否带有file://前缀</param>
        /// <param name="newUrl"></param>
        /// <returns></returns>
        public static bool TryGetDocumentResourceUrl(string url, bool withFileProtocol, out string newUrl)
        {
            if (withFileProtocol)
                newUrl = DocumentResourcesPath + url;
            else
                newUrl = DocumentResourcesPathWithoutFileProtocol + url;

            if (File.Exists(DocumentResourcesPathWithoutFileProtocol + url))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// (not android ) only! Android资源不在目录！
        /// Editor返回文件系统目录，运行时返回StreamingAssets目录
        /// </summary>
        /// <param name="url"></param>
        /// <param name="withFileProtocol">是否带有file://前缀</param>
        /// <param name="newUrl"></param>
        /// <returns></returns>
        public static bool TryGetInAppStreamingUrl(string url, bool withFileProtocol, out string newUrl)
        {
            if (withFileProtocol)
                newUrl = BundlesPathWithProtocol + url;
            else
                newUrl = BundlesPathWithoutFileProtocol + url;

            // 注意，StreamingAssetsPath在Android平台時，壓縮在apk里面，不要做文件檢查了
            if (!Application.isEditor && Application.platform == RuntimePlatform.Android)
            {
                if (!KEngineAndroidPlugin.IsAssetExists(BundlesPathRelative + url))
                    return false;
            }
            else
            {
                // Editor, 非android运行，直接进行文件检查
                if (!File.Exists(BundlesPathWithoutFileProtocol + url))
                {
                    return false;
                }
            }

            // Windows/Edtiro平台下，进行大小敏感判断
            if (Application.isEditor)
            {
                var result = FileExistsWithDifferentCase(BundlesPathWithoutFileProtocol + url);
                if (!result)
                {
                    Log.Error("[大小写敏感]发现一个资源 {0}，大小写出现问题，在Windows可以读取，手机不行，请改表修改！", url);
                }
            }
            return true;
        }

        /// <summary>
        /// 大小写敏感地进行文件判断, Windows Only
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        private static bool FileExistsWithDifferentCase(string filePath)
        {
            if (File.Exists(filePath))
            {
                string directory = Path.GetDirectoryName(filePath);
                string fileTitle = Path.GetFileName(filePath);
                string[] files = Directory.GetFiles(directory, fileTitle);
                var realFilePath = files[0].Replace("\\", "/");
                filePath = filePath.Replace("\\", "/");

                return String.CompareOrdinal(realFilePath, filePath) == 0;
            }
            return false;
        }

        /// <summary>
        /// 獲取app數據目錄，可寫，同Application.PersitentDataPath，但在windows平台時為了避免www類中文目錄無法讀取問題，單獨實現
        /// </summary>
        /// <returns></returns>
        public static string GetAppDataPath()
        {
            // Windows 时使用特定的目录，避免中文User的存在 
            // 去掉自定义PersistentDataPath, 2015/11/18， 务必要求Windows Users是英文
            //if (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.WindowsWebPlayer)
            //{
            //    string dataPath = Application.dataPath + "/../Library/UnityWinPersistentDataPath";
            //    if (!Directory.Exists(dataPath))
            //        Directory.CreateDirectory(dataPath);
            //    return dataPath;
            //}
            return Application.persistentDataPath;
        }

        private void Update()
        {
            AbstractResourceLoader.CheckGcCollect();
        }
    }
}