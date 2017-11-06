---
--- Created by husheng.
--- DateTime: 2017/11/6 16:30
---
CtrlNames = {
    Prompt = "PromptCtrl",
    Message = "MessageCtrl"
}

PanelNames = {
    "PromptPanel",
    "MessagePanel",
}

--当前使用的协议类型--

Util = LuaFramework.Util;

LuaHelper = LuaFramework.LuaHelper;


resMgr = LuaHelper.GetResManager();
--panelMgr = LuaHelper.GetPanelManager();
--soundMgr = LuaHelper.GetSoundManager();
--networkMgr = LuaHelper.GetNetManager();
sceneMgr = LuaHelper.GetSceneManager();

WWW = UnityEngine.WWW;
GameObject = UnityEngine.GameObject;