/***************************************************************************************
* Name: BuildBat.cs
* Function:AssetBundle打包方法;
* 
* Version     Date                Name                            Change Content
* ────────────────────────────────────────────────────────────────────────────────
* V1.0.0    20170901    http://blog.csdn.net/husheng0
* 
* Copyright (c). All rights reserved.
* 
***************************************************************************************/

using UnityEngine;
using System.Collections;
using UnityEditor;
using System;
using System.Diagnostics;
using Debug = UnityEngine.Debug;
using System.IO;
using System.Collections.Generic;

public static class BuildBat
{
    /// <summary>
    /// 打包AssetBundle,默认只打包有更改的资源;
    /// </summary>
    [MenuItem("AssetBundleTools/BuildAllAssetBundle")]
    public static void BuildAllAssetBundle()
    {
        bool state = true;
#if UNITY_EDITOR
        state = EditorUtility.DisplayDialog("依赖关系生成选择框", "是否确认重新生成依赖关系，不能确认请点击OK。","OK->重新分析资源依赖关系", "Cancel->直接打包AssetBundle");
#endif
        if (state)
        {
            ToLuaMenu.ClearLuaFilesFromSrcPath();
            ToLuaMenu.CopyLuaFilesToSrcPath();

            AssetDependenciesAnalysis analysiser = new AssetDependenciesAnalysis();
            analysiser.AnalysisAllAsset();
            //tips:Unity5.x Scripts not need to build AssetBundle
            //analysiser.BuildAllScripts();
        }
        BuildAssetBundle();
    }

    [MenuItem("AssetBundleTools/Build Lua")]
    public static void BuildLua()
    {

        ToLuaMenu.ClearLuaFilesFromSrcPath();
        ToLuaMenu.CopyLuaFilesToSrcPath();

        string[] allPath = Directory.GetFiles(FilePathUtil.resPath+"Lua/", "*.*", SearchOption.AllDirectories);

        //剔除.meta文件;
        List<string> allLuaAsset = new List<string>();
        foreach (string tempPath in allPath)
        {
            string path = tempPath.Replace("\\", "/");
            if (Path.GetExtension(path) == ".meta") continue;
            allLuaAsset.Add(path);
        }
        int index = 0;
        foreach (string tempPath in allLuaAsset)
        {
            index++;
            EditorUtility.DisplayProgressBar("Set Asset AssetBundle Name", "AssetBundle Name Setting Progress", (index / allLuaAsset.Count));
            AssetImporter importer = AssetImporter.GetAtPath(tempPath);
            if (importer != null)
            {
                importer.assetBundleName = FilePathUtil.GetAssetBundleFileName(AssetType.Lua, "Lua");
                AssetDatabase.ImportAsset(tempPath);
            }
        }
        EditorUtility.ClearProgressBar();

        //tips:Unity5.x Scripts not need to build AssetBundle
        //analysiser.BuildAllScripts();
        BuildAssetBundle();
    }

    /// <summary>
    /// 打包特定的AssetBundle,依赖的资源会被打包到相应的AssetBundle中;
    /// </summary>
    /// <param name="builds">打包信息</param>
    public static void BuildAssetBundle(AssetBundleBuild[] builds)
    {
        Stopwatch watch = Stopwatch.StartNew();//开启计时;
        BuildPipeline.BuildAssetBundles(BuildDefine.assetBundlePath, builds, BuildDefine.options, BuildDefine.buildTarget);
        watch.Stop();
        Debug.LogWarning(string.Format("[BuildBat]BuildAllAssetBundle AssetBundleBuild Spend Time:{0}s", watch.Elapsed.TotalSeconds));
        AssetDatabase.Refresh();
        EditorUtility.UnloadUnusedAssetsImmediate();
    }

    /// <summary>
    /// 根据AssetBundle Name打包全部AssetBundle;
    /// </summary>
    public static void BuildAssetBundle()
    {
        Stopwatch watch = Stopwatch.StartNew();//开启计时;
        BuildPipeline.BuildAssetBundles(BuildDefine.assetBundlePath,BuildDefine.options, BuildDefine.buildTarget);
        watch.Stop();
        Debug.LogWarning(string.Format("[BuildBat]BuildAllAssetBundle Spend Time:{0}s", watch.Elapsed.TotalSeconds));
        AssetDatabase.Refresh();
        EditorUtility.UnloadUnusedAssetsImmediate();
    }
}
