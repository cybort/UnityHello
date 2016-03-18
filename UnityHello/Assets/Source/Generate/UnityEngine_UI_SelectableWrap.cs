﻿using System;
using LuaInterface;

public class UnityEngine_UI_SelectableWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.UI.Selectable), typeof(UnityEngine.EventSystems.UIBehaviour));
		L.RegFunction("IsInteractable", IsInteractable);
		L.RegFunction("FindSelectable", FindSelectable);
		L.RegFunction("FindSelectableOnLeft", FindSelectableOnLeft);
		L.RegFunction("FindSelectableOnRight", FindSelectableOnRight);
		L.RegFunction("FindSelectableOnUp", FindSelectableOnUp);
		L.RegFunction("FindSelectableOnDown", FindSelectableOnDown);
		L.RegFunction("OnMove", OnMove);
		L.RegFunction("OnPointerDown", OnPointerDown);
		L.RegFunction("OnPointerUp", OnPointerUp);
		L.RegFunction("OnPointerEnter", OnPointerEnter);
		L.RegFunction("OnPointerExit", OnPointerExit);
		L.RegFunction("OnSelect", OnSelect);
		L.RegFunction("OnDeselect", OnDeselect);
		L.RegFunction("Select", Select);
		L.RegFunction("New", _CreateUnityEngine_UI_Selectable);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("allSelectables", get_allSelectables, null);
		L.RegVar("navigation", get_navigation, set_navigation);
		L.RegVar("transition", get_transition, set_transition);
		L.RegVar("colors", get_colors, set_colors);
		L.RegVar("spriteState", get_spriteState, set_spriteState);
		L.RegVar("animationTriggers", get_animationTriggers, set_animationTriggers);
		L.RegVar("targetGraphic", get_targetGraphic, set_targetGraphic);
		L.RegVar("interactable", get_interactable, set_interactable);
		L.RegVar("image", get_image, set_image);
		L.RegVar("animator", get_animator, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_UI_Selectable(IntPtr L)
	{
		return LuaDLL.tolua_error(L, "UnityEngine.UI.Selectable class does not have a constructor function");
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsInteractable(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Selectable));
			bool o = obj.IsInteractable();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindSelectable(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Selectable));
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			UnityEngine.UI.Selectable o = obj.FindSelectable(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindSelectableOnLeft(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Selectable));
			UnityEngine.UI.Selectable o = obj.FindSelectableOnLeft();
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindSelectableOnRight(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Selectable));
			UnityEngine.UI.Selectable o = obj.FindSelectableOnRight();
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindSelectableOnUp(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Selectable));
			UnityEngine.UI.Selectable o = obj.FindSelectableOnUp();
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindSelectableOnDown(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Selectable));
			UnityEngine.UI.Selectable o = obj.FindSelectableOnDown();
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnMove(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Selectable));
			UnityEngine.EventSystems.AxisEventData arg0 = (UnityEngine.EventSystems.AxisEventData)ToLua.CheckObject(L, 2, typeof(UnityEngine.EventSystems.AxisEventData));
			obj.OnMove(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPointerDown(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Selectable));
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
			obj.OnPointerDown(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPointerUp(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Selectable));
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
			obj.OnPointerUp(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPointerEnter(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Selectable));
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
			obj.OnPointerEnter(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPointerExit(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Selectable));
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
			obj.OnPointerExit(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnSelect(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Selectable));
			UnityEngine.EventSystems.BaseEventData arg0 = (UnityEngine.EventSystems.BaseEventData)ToLua.CheckObject(L, 2, typeof(UnityEngine.EventSystems.BaseEventData));
			obj.OnSelect(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnDeselect(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Selectable));
			UnityEngine.EventSystems.BaseEventData arg0 = (UnityEngine.EventSystems.BaseEventData)ToLua.CheckObject(L, 2, typeof(UnityEngine.EventSystems.BaseEventData));
			obj.OnDeselect(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Select(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.Selectable));
			obj.Select();
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
	static int get_allSelectables(IntPtr L)
	{
		ToLua.PushObject(L, UnityEngine.UI.Selectable.allSelectables);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_navigation(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;
			UnityEngine.UI.Navigation ret = obj.navigation;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index navigation on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_transition(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;
			UnityEngine.UI.Selectable.Transition ret = obj.transition;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index transition on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_colors(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;
			UnityEngine.UI.ColorBlock ret = obj.colors;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index colors on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_spriteState(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;
			UnityEngine.UI.SpriteState ret = obj.spriteState;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index spriteState on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_animationTriggers(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;
			UnityEngine.UI.AnimationTriggers ret = obj.animationTriggers;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index animationTriggers on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_targetGraphic(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;
			UnityEngine.UI.Graphic ret = obj.targetGraphic;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index targetGraphic on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_interactable(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;
			bool ret = obj.interactable;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index interactable on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_image(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;
			UnityEngine.UI.Image ret = obj.image;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index image on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_animator(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;
			UnityEngine.Animator ret = obj.animator;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index animator on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_navigation(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;
			UnityEngine.UI.Navigation arg0 = (UnityEngine.UI.Navigation)ToLua.CheckObject(L, 2, typeof(UnityEngine.UI.Navigation));
			obj.navigation = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index navigation on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_transition(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;
			UnityEngine.UI.Selectable.Transition arg0 = (UnityEngine.UI.Selectable.Transition)ToLua.CheckObject(L, 2, typeof(UnityEngine.UI.Selectable.Transition));
			obj.transition = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index transition on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_colors(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;
			UnityEngine.UI.ColorBlock arg0 = (UnityEngine.UI.ColorBlock)ToLua.CheckObject(L, 2, typeof(UnityEngine.UI.ColorBlock));
			obj.colors = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index colors on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_spriteState(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;
			UnityEngine.UI.SpriteState arg0 = (UnityEngine.UI.SpriteState)ToLua.CheckObject(L, 2, typeof(UnityEngine.UI.SpriteState));
			obj.spriteState = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index spriteState on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_animationTriggers(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;
			UnityEngine.UI.AnimationTriggers arg0 = (UnityEngine.UI.AnimationTriggers)ToLua.CheckObject(L, 2, typeof(UnityEngine.UI.AnimationTriggers));
			obj.animationTriggers = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index animationTriggers on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_targetGraphic(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;
			UnityEngine.UI.Graphic arg0 = (UnityEngine.UI.Graphic)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.UI.Graphic));
			obj.targetGraphic = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index targetGraphic on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_interactable(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.interactable = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index interactable on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_image(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Selectable obj = (UnityEngine.UI.Selectable)o;
			UnityEngine.UI.Image arg0 = (UnityEngine.UI.Image)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.UI.Image));
			obj.image = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index image on a nil value" : e.Message);
		}
	}
}

