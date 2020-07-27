using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AppNavigation : MonoBehaviour
{
    public void ExitApp()
    {
        Application.Quit();
    }

    public void OpenScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
