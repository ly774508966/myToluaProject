using UnityEngine;
using System.Collections;
using LuaInterface;
using System.IO;

/// <summary>
/// 集成自LuaFileUtils,重写里面的ReadFile;
/// </summary>
public class LuaLoader : LuaFileUtils
{

    // Use this for initialization
    public LuaLoader()
    {
        instance = this;
    }

    /// <summary>
    /// 添加打入Lua代码的AssetBundle;
    /// </summary>
    /// <param name="bundle"></param>
    public void AddBundle()
    {
        AssetBundle bundle = AssetBundleMgr.Instance.LoadAssetBundleSync(AssetType.Lua, "Lua");
        if (bundle != null)
        {
            base.AddSearchBundle("lua", bundle);
        }
    }

    /// <summary>
    /// 当LuaVM加载Lua文件的时候，这里就会被调用,
    /// 用户可以自定义加载行为，只要返回byte[]即可;
    /// </summary>
    /// <param name="fileName"></param>
    /// <returns></returns>
    public override byte[] ReadFile(string fileName)
    {
        return base.ReadFile(fileName);
    }
}
