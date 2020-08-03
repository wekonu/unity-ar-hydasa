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

    private int i = 0;

    private void Awake()
    {
        slideList = slides.ToList<GameObject>();
        Debug.Log("wahyu: total slides" + slideList.Count);
        Debug.Log("wahyu: i = " + i);
        currentSlide = slideList[i];
        currentSlide.SetActive(true);
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
    }
}
