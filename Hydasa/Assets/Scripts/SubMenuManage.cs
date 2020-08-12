using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SubMenuManage : MonoBehaviour
{
    [SerializeField]
    public GameObject[] subMenus;

    private static List<GameObject> subMenuList;
    private GameObject currentSlide;
    private GameObject slideBuffer;

    private int i = 0;

    private void Awake()
    {
        subMenuList = subMenus.ToList<GameObject>();
        for (int j = 0; j < subMenuList.Count; j++)
        {
            subMenuList[j].SetActive(false);
        }
        currentSlide = subMenuList[i];
        slideBuffer = subMenuList[i];
        currentSlide.SetActive(true);
    }

    public void OpenSubMenu(GameObject subMenu)
    {
        currentSlide = subMenu;
        currentSlide.SetActive(true);
        slideBuffer.SetActive(false);
        slideBuffer = currentSlide;
    }
}
