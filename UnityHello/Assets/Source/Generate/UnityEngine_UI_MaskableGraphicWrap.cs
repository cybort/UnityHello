﻿using System;
using LuaInterface;

public class UnityEngine_UI_MaskableGraphicWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.UI.MaskableGraphic), typeof(UnityEngine.UI.Graphic));
		L.RegFunction("GetModifiedMaterial", GetModifiedMaterial);
		L.RegFunction("Cull", Cull);
		L.RegFunction("SetClipRect", SetClipRect);
		L.RegFunction("RecalculateClipping", RecalculateClipping);
		L.RegFunction("RecalculateMasking", RecalculateMasking);
		L.RegFunction("New", _CreateUnityEngine_UI_MaskableGraphic);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("onCullStateChanged", get_onCullStateChanged, set_onCullStateChanged);
		L.RegVar("maskable", get_maskable, set_maskable);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_UI_MaskableGraphic(IntPtr L)
	{
		return LuaDLL.tolua_error(L, "UnityEngine.UI.MaskableGraphic class does not have a constructor function");
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetModifiedMaterial(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.UI.MaskableGraphic obj = (UnityEngine.UI.MaskableGraphic)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.MaskableGraphic));
			UnityEngine.Material arg0 = (UnityEngine.Material)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.Material));
			UnityEngine.Material o = obj.GetModifiedMaterial(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Cull(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UnityEngine.UI.MaskableGraphic obj = (UnityEngine.UI.MaskableGraphic)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.MaskableGraphic));
			UnityEngine.Rect arg0 = (UnityEngine.Rect)ToLua.CheckObject(L, 2, typeof(UnityEngine.Rect));
			bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
			obj.Cull(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetClipRect(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UnityEngine.UI.MaskableGraphic obj = (UnityEngine.UI.MaskableGraphic)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.MaskableGraphic));
			UnityEngine.Rect arg0 = (UnityEngine.Rect)ToLua.CheckObject(L, 2, typeof(UnityEngine.Rect));
			bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
			obj.SetClipRect(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RecalculateClipping(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.MaskableGraphic obj = (UnityEngine.UI.MaskableGraphic)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.MaskableGraphic));
			obj.RecalculateClipping();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RecalculateMasking(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.MaskableGraphic obj = (UnityEngine.UI.MaskableGraphic)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.MaskableGraphic));
			obj.RecalculateMasking();
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
	static int get_onCullStateChanged(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.MaskableGraphic obj = (UnityEngine.UI.MaskableGraphic)o;
			UnityEngine.UI.MaskableGraphic.CullStateChangedEvent ret = obj.onCullStateChanged;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onCullStateChanged on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_maskable(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.MaskableGraphic obj = (UnityEngine.UI.MaskableGraphic)o;
			bool ret = obj.maskable;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index maskable on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onCullStateChanged(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.MaskableGraphic obj = (UnityEngine.UI.MaskableGraphic)o;
			UnityEngine.UI.MaskableGraphic.CullStateChangedEvent arg0 = (UnityEngine.UI.MaskableGraphic.CullStateChangedEvent)ToLua.CheckObject(L, 2, typeof(UnityEngine.UI.MaskableGraphic.CullStateChangedEvent));
			obj.onCullStateChanged = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onCullStateChanged on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_maskable(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.MaskableGraphic obj = (UnityEngine.UI.MaskableGraphic)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.maskable = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index maskable on a nil value" : e.Message);
		}
	}
}

