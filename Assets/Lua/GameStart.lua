---
--- Created by husheng.
--- DateTime: 2017/11/6 16:24
---
require "Common/define"

GameStart = {};
local this = GameStart;

function GameStart.OnInitOK()
    print("=====>C# Call Lua success!")
    if(resMgr==nil)
    then
        print("resMgr==nil")
    else
        print("resMgr!=nil")
    end
    if(sceneMgr==nil)
    then
        print("sceneMgr==nil")
    else
        print("sceneMgr!=nil")
    end

    sceneMgr:Test()  --Lua Call C#

    this.OpenScene_One()

end

function GameStart.OpenScene_One()
    print("=====>C# Call Lua success!")
    sceneMgr:ShowScene(1)
end

function GameStart.OpenScene_Two()
    print("=====>C# Call Lua success!")
    sceneMgr:ShowScene(2)
end