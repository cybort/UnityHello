﻿using System;
using LuaInterface;

public class UnityEngine_UI_GraphicWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.UI.Graphic), typeof(UnityEngine.EventSystems.UIBehaviour));
		L.RegFunction("SetAllDirty", SetAllDirty);
		L.RegFunction("SetLayoutDirty", SetLayoutDirty);
		L.RegFunction("SetVerticesDirty", SetVerticesDirty);
		L.RegFunction("SetMaterialDirty", SetMaterialDirty);
		L.RegFunction("Rebuild", Rebuild);
		L.RegFunction("LayoutComplete", LayoutComplete);
		L.RegFunction("GraphicUpdateComplete", GraphicUpdateComplete);
		L.RegFunction("SetNativeSize", SetNativeSize);
		L.RegFunction("Raycast", Raycast);
		L.RegFunction("PixelAdjustPoint", PixelAdjustPoint);
		L.RegFunction("GetPixelAdjustedRect", GetPixelAdjustedRect);
		L.RegFunction("CrossFadeColor", CrossFadeColor);
		L.RegFunction("CrossFadeAlpha", CrossFadeAlpha);
		L.RegFunction("RegisterDirtyLayoutCallback", RegisterDirtyLayoutCallback);
		L.RegFunction("UnregisterDirtyLayoutCallback", UnregisterDirtyLayoutCallback);
		L.RegFunction("RegisterDirtyVerticesCallback", RegisterDirtyVerticesCallback);
		L.RegFunction("UnregisterDirtyVerticesCallback", UnregisterDirtyVerticesCallback);
		L.RegFunction("RegisterDirtyMaterialCallback", RegisterDirtyMaterialCallback);
		L.RegFunction("UnregisterDirtyMaterialCallback", UnregisterDirtyMaterialCallback);
		L.RegFunction("New", _CreateUnityEngine_UI_Graphic);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("defaultGraphicMaterial", get_defaultGraphicMaterial, null);
		L.RegVar("color", get_color, set_color);
		L.RegVar("raycastTarget", get_raycastTarget, set_raycastTarget);
		L.RegVar("depth", get_depth, null);
		L.RegVar("rectTransform", get_rectTransform, null);
		L.RegVar("canvas", get_canvas, null);
		L.RegVar("canvasRenderer", get_canvasRenderer, null);
		L.RegVar("defaultMaterial", get_defaultMaterial, null);
		L.RegVar("material", get_material, set_material);
		L.RegVar("materialForRendering", get_materialForRendering, null);
		L.RegVar("mainTexture", get_mainTexture, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_UI_Graphic(IntPtr L)
	{
		return LuaDLL.tolua_error(L, "UnityEngine.UI.Graphic class does not have a constructor function");
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetAllDirty(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Graphic));
			obj.SetAllDirty();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetLayoutDirty(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Graphic));
			obj.SetLayoutDirty();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetVerticesDirty(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Graphic));
			obj.SetVerticesDirty();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetMaterialDirty(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Graphic));
			obj.SetMaterialDirty();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Rebuild(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Graphic));
			UnityEngine.UI.CanvasUpdate arg0 = (UnityEngine.UI.CanvasUpdate)ToLua.CheckObject(L, 2, typeof(UnityEngine.UI.CanvasUpdate));
			obj.Rebuild(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LayoutComplete(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Graphic));
			obj.LayoutComplete();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GraphicUpdateComplete(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Graphic));
			obj.GraphicUpdateComplete();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetNativeSize(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Graphic));
			obj.SetNativeSize();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Raycast(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Graphic));
			UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 2);
			UnityEngine.Camera arg1 = (UnityEngine.Camera)ToLua.CheckUnityObject(L, 3, typeof(UnityEngine.Camera));
			bool o = obj.Raycast(arg0, arg1);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PixelAdjustPoint(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Graphic));
			UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 2);
			UnityEngine.Vector2 o = obj.PixelAdjustPoint(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPixelAdjustedRect(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Graphic));
			UnityEngine.Rect o = obj.GetPixelAdjustedRect();
			ToLua.PushValue(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CrossFadeColor(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 5);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Graphic));
			UnityEngine.Color arg0 = ToLua.ToColor(L, 2);
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
			bool arg2 = LuaDLL.luaL_checkboolean(L, 4);
			bool arg3 = LuaDLL.luaL_checkboolean(L, 5);
			obj.CrossFadeColor(arg0, arg1, arg2, arg3);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CrossFadeAlpha(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Graphic));
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
			bool arg2 = LuaDLL.luaL_checkboolean(L, 4);
			obj.CrossFadeAlpha(arg0, arg1, arg2);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RegisterDirtyLayoutCallback(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Graphic));
			UnityEngine.Events.UnityAction arg0 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (UnityEngine.Events.UnityAction)ToLua.CheckObject(L, 2, typeof(UnityEngine.Events.UnityAction));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 2);
				arg0 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Events.UnityAction), func) as UnityEngine.Events.UnityAction;
			}

			obj.RegisterDirtyLayoutCallback(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnregisterDirtyLayoutCallback(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Graphic));
			UnityEngine.Events.UnityAction arg0 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (UnityEngine.Events.UnityAction)ToLua.CheckObject(L, 2, typeof(UnityEngine.Events.UnityAction));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 2);
				arg0 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Events.UnityAction), func) as UnityEngine.Events.UnityAction;
			}

			obj.UnregisterDirtyLayoutCallback(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RegisterDirtyVerticesCallback(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Graphic));
			UnityEngine.Events.UnityAction arg0 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (UnityEngine.Events.UnityAction)ToLua.CheckObject(L, 2, typeof(UnityEngine.Events.UnityAction));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 2);
				arg0 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Events.UnityAction), func) as UnityEngine.Events.UnityAction;
			}

			obj.RegisterDirtyVerticesCallback(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnregisterDirtyVerticesCallback(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Graphic));
			UnityEngine.Events.UnityAction arg0 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (UnityEngine.Events.UnityAction)ToLua.CheckObject(L, 2, typeof(UnityEngine.Events.UnityAction));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 2);
				arg0 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Events.UnityAction), func) as UnityEngine.Events.UnityAction;
			}

			obj.UnregisterDirtyVerticesCallback(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RegisterDirtyMaterialCallback(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Graphic));
			UnityEngine.Events.UnityAction arg0 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (UnityEngine.Events.UnityAction)ToLua.CheckObject(L, 2, typeof(UnityEngine.Events.UnityAction));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 2);
				arg0 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Events.UnityAction), func) as UnityEngine.Events.UnityAction;
			}

			obj.RegisterDirtyMaterialCallback(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnregisterDirtyMaterialCallback(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Graphic));
			UnityEngine.Events.UnityAction arg0 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (UnityEngine.Events.UnityAction)ToLua.CheckObject(L, 2, typeof(UnityEngine.Events.UnityAction));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 2);
				arg0 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Events.UnityAction), func) as UnityEngine.Events.UnityAction;
			}

			obj.UnregisterDirtyMaterialCallback(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_ToString(IntPtr L)
	{
		object obj = ToLua.ToObject(L, 1);

		if (obj != null)
		{
			LuaDLL.lua_pushstring(L, obj.ToString());
		}
		else
		{
			LuaDLL.lua_pushnil(L);
		}

		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_defaultGraphicMaterial(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.UI.Graphic.defaultGraphicMaterial);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_color(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)o;
			UnityEngine.Color ret = obj.color;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index color on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_raycastTarget(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)o;
			bool ret = obj.raycastTarget;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index raycastTarget on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_depth(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)o;
			int ret = obj.depth;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index depth on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_rectTransform(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)o;
			UnityEngine.RectTransform ret = obj.rectTransform;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index rectTransform on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_canvas(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)o;
			UnityEngine.Canvas ret = obj.canvas;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index canvas on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_canvasRenderer(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)o;
			UnityEngine.CanvasRenderer ret = obj.canvasRenderer;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index canvasRenderer on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_defaultMaterial(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)o;
			UnityEngine.Material ret = obj.defaultMaterial;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index defaultMaterial on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_material(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)o;
			UnityEngine.Material ret = obj.material;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index material on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_materialForRendering(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)o;
			UnityEngine.Material ret = obj.materialForRendering;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index materialForRendering on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mainTexture(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)o;
			UnityEngine.Texture ret = obj.mainTexture;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mainTexture on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_color(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)o;
			UnityEngine.Color arg0 = ToLua.ToColor(L, 2);
			obj.color = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index color on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_raycastTarget(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.raycastTarget = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index raycastTarget on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_material(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Graphic obj = (UnityEngine.UI.Graphic)o;
			UnityEngine.Material arg0 = (UnityEngine.Material)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.Material));
			obj.material = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index material on a nil value" : e.Message);
		}
	}
}

