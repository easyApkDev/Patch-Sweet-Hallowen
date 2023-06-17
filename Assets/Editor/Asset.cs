using UnityEngine;
using UnityEditor;
using System.IO;
 
public class CreateAssetBundles
{
    [MenuItem("EasyApk/Create Patch Sc")]
    static void BuildAllAssetBundles()
    {
    string assetBundleDirectory = "Assets/StreamingAssets";
    if (!Directory.Exists(assetBundleDirectory))
    {
        Directory.CreateDirectory(assetBundleDirectory);
    }
    BuildPipeline.BuildAssetBundles(assetBundleDirectory, BuildAssetBundleOptions.None, EditorUserBuildSettings.activeBuildTarget);
    }
}