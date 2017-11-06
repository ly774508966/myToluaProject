﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class SceneMgrWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(SceneMgr), typeof(MonoSingletonMgr<SceneMgr>));
		L.RegFunction("ShowScene", ShowScene);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ShowScene(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SceneMgr obj = (SceneMgr)ToLua.CheckObject<SceneMgr>(L, 1);
			GameSceneEnum arg0 = (GameSceneEnum)ToLua.CheckObject(L, 2, typeof(GameSceneEnum));
			obj.ShowScene(arg0);
			return 0;
		}
		catch (Exception e)
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
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

