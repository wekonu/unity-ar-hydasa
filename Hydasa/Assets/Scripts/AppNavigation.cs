using System.Collections;
using System.Collections.Generic;
using System.Transactions;
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
        SceneTransition.OpenScene(sceneName);
    }

    public void OpenLink(string url)
    {
        Application.OpenURL(url);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (SceneManager.GetActiveScene().name == "MainMenu")
            {
                OpenScene("Keluar");
            }
            else if (SceneManager.GetActiveScene().name == "Keluar")
            {
                ExitApp();
            }
            else
            {
                OpenScene("MainMenu");
            }
        }
    }
}
