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

util = Util;

luaHelper =LuaHelper;


resMgr = luaHelper.GetResManager();
--panelMgr = LuaHelper.GetPanelManager();
--soundMgr = LuaHelper.GetSoundManager();
--networkMgr = LuaHelper.GetNetManager();
sceneMgr = luaHelper.GetSceneManager();

WWW = UnityEngine.WWW;
GameObject = UnityEngine.GameObject;