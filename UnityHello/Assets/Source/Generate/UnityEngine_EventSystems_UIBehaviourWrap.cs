﻿using System;
using LuaInterface;

public class UnityEngine_EventSystems_UIBehaviourWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.EventSystems.UIBehaviour), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("IsActive", IsActive);
		L.RegFunction("IsDestroyed", IsDestroyed);
		L.RegFunction("New", _CreateUnityEngine_EventSystems_UIBehaviour);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", Lua_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_EventSystems_UIBehaviour(IntPtr L)
	{
		return LuaDLL.tolua_error(L, "UnityEngine.EventSystems.UIBehaviour class does not have a constructor function");
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsActive(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.EventSystems.UIBehaviour obj = (UnityEngine.EventSystems.UIBehaviour)ToLua.CheckObject(L, 1, typeof(UnityEngine.EventSystems.UIBehaviour));
			bool o = obj.IsActive();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsDestroyed(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.EventSystems.UIBehaviour obj = (UnityEngine.EventSystems.UIBehaviour)ToLua.CheckObject(L, 1, typeof(UnityEngine.EventSystems.UIBehaviour));
			bool o = obj.IsDestroyed();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
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
}

