using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingManage : MonoBehaviour
{
    private void Start()
    {
        Invoke("LoadScene", .2f);
    }

    private void LoadScene()
    {
        SceneTransition.OpenTargetScene();
    }
}
