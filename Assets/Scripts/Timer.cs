using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float countDown = 30f;
    [SerializeField] float reviewAnswer = 5f;

    public bool loadNextQuestion;
    public bool isAnsweringQuestion;
    public float fillFraction;

    float timerValue;


    void Update()
    {
        UpdateTimer();   
    }

    public void CancelTimer()
    {
        timerValue = 0f;
    }

    void UpdateTimer()
    {
        timerValue -= Time.deltaTime;
        if (isAnsweringQuestion)
        {
            if (timerValue > 0)
            {
                fillFraction = timerValue / countDown;
            }
            else
            {
                isAnsweringQuestion=false;
                timerValue = reviewAnswer;
            }
        }
        else
        {
            if (timerValue > 0)
            {
                fillFraction = timerValue / reviewAnswer;

            }
            else
            {
                isAnsweringQuestion = true;
                timerValue = countDown;
                loadNextQuestion = true;
            }
        }
        
        Debug.Log(isAnsweringQuestion +":"+ timerValue + ":" + fillFraction);
    }
}
