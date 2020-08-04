using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class SceneTransition
{
    private static string targetScene;

    public static void OpenScene(string sceneName)
    {
        SceneManager.LoadScene("Loading");
        targetScene = sceneName;
    }

    public static void OpenTargetScene()
    {
        SceneManager.LoadScene(targetScene);
    }
}
