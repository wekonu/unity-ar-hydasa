using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenSwipe : MonoBehaviour
{
    public float maxTime = 0.5f;
    public float minSwipeDist = 50f;
    float startTime;
    float endTime;
    float swipeDistance;
    float swipeTime;
    Vector3 startPos;
    Vector3 endPos;

    SlideManage slideManage;

    private void Awake()
    {
        slideManage = FindObjectOfType<SlideManage>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                startTime = Time.time;
                startPos = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                endTime = Time.time;
                endPos = touch.position;
                swipeDistance = (endPos - startPos).magnitude;
                swipeTime = endTime - startTime;
                if (swipeTime < maxTime && swipeDistance > minSwipeDist)
                {
                    swiper();
                }
            }
        }

    }

    void swiper()
    {
        Vector2 distance = endPos - startPos;
        if (Mathf.Abs(distance.x) > Mathf.Abs(distance.y))
        {
            if (distance.x > 0)
            {
                // swipe left
                if (!slideManage.IsFirstSlide())
                    slideManage.OpenPreviousSlide();
            }
            else if (distance.x < 0)
            {
                // swipe right
                if (!slideManage.IsLastSlide())
                    slideManage.OpenNextSlide();
            }
        }
        else if (Mathf.Abs(distance.x) < Mathf.Abs(distance.y))
        {
            if (distance.y > 0)
            {
                //swipe up
            }
            else if (distance.y < 0)
            {
                //swipe down
            }
        }
    }
}
