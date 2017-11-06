---
--- Created by husheng.
--- DateTime: 2017/11/6 16:24
---

GameStart = {};
local this = GameStart;

function GameStart.OnInitOK()
    print("[Lua]=====>OnInitOK")
    OpenScene_One()
end

function GameStart.OpenScene_One()
    sceneMgr.ShowScene(1)
end

function GameStart.OpenScene_Two()
    sceneMgr.ShowScene(2)
end