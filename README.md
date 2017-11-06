# myToluaProject
My unity gameframework integration tolua.

software：Unity5.3.8/visual studio2013.

[①tolua](https://github.com/topameng/tolua)

[②myAssetBundleTools](https://github.com/HushengStudent/myAssetBundleTools)

progress:

1、整合部分LuaFramework_NGUI：

①LuaBehaviour.cs //便于调用Lua代码中的Awake();Start();Update()......

②LuaLoader.cs  //Lua的AssetBundle加载

③LuaManager.cs 

④LuaHelper.cs //给Lua提供调用C#接口

⑤Util.cs  //工具类

2、整合AssetBundle打包工具：

[myAssetBundleTools](https://github.com/HushengStudent/myAssetBundleTools)

新增Lua代码打包。去掉Lua代码路径加载方式，全部改为从AssetBundle加载。