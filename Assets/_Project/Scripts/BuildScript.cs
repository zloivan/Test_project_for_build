using UnityEditor;
using UnityEngine;

public class BuildScript
{
    public static void Build()
    {
        var buildPath = "build/WebGL";
        var buildVersion = Application.version;

        if (!System.IO.Directory.Exists(buildPath))
        {
            System.IO.Directory.CreateDirectory(buildPath);
        }

        var buildPlayerOptions = new BuildPlayerOptions
        {
            scenes = new[] { "Assets/Scenes/MainScene.unity" },
            locationPathName = buildPath,
            target = BuildTarget.WebGL,
            options = BuildOptions.None
        };

        PlayerSettings.bundleVersion = buildVersion;
        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }
}
