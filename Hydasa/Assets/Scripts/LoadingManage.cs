using UnityEngine;

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
