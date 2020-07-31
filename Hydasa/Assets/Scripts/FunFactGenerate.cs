using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunFactGenerate : MonoBehaviour
{
    AppNavigation m_AppNavigation;

    private void Start()
    {
        m_AppNavigation = FindObjectOfType<AppNavigation>();
        m_AppNavigation.OpenScene("MainMenu");
    }
}
