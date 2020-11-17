using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SlideManage : MonoBehaviour
{
    [SerializeField]
    public GameObject[] slides;

    private static List<GameObject> slideList;
    private GameObject currentSlide;
    private GameObject btnLeft;
    private GameObject btnRight;

    private int i = 0;

    private void Awake()
    {
        btnLeft = GameObject.Find("Btn_Left");
        btnRight = GameObject.Find("Btn_Right");
        slideList = slides.ToList<GameObject>();
        for (int j = 0; j < slideList.Count; j++)
        {
            slideList[j].SetActive(false);
        }
        currentSlide = slideList[i];
        currentSlide.SetActive(true);
        IsFirstSlide();
    }

    public void OpenNextSlide()
    {
        if(currentSlide != slideList[slideList.Count - 1])
        {
            i++;
            currentSlide.SetActive(false);
            currentSlide = slideList[i];
            currentSlide.SetActive(true);
        }
        else
        {
            i = 0;
            currentSlide.SetActive(false);
            currentSlide = slideList[i];
            currentSlide.SetActive(true);
        }
        IsFirstSlide();
        IsLastSlide();
    }

    public void OpenPreviousSlide()
    {
        if(currentSlide != slideList[0])
        {
            i--;
            currentSlide.SetActive(false);
            currentSlide = slideList[i];
            currentSlide.SetActive(true);
        }
        else
        {
            i = slideList.Count - 1;
            currentSlide.SetActive(false);
            currentSlide = slideList[i];
            currentSlide.SetActive(true);
        }
        IsFirstSlide();
        IsLastSlide();
    }

    public bool IsFirstSlide()
    {
        bool activateLeft = false;
        if (currentSlide == slideList[0])
        {
            btnLeft.SetActive(activateLeft);
            btnRight.SetActive(!activateLeft);
            return true;
        }
        else
            return false;
    }

    public bool IsLastSlide()
    {
        bool activateRight = false;
        if (currentSlide == slideList[slideList.Count - 1])
        {
            btnRight.SetActive(activateRight);
            btnLeft.SetActive(!activateRight);
            return true;
        }
        else
            return false;
    }
}
