using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToCompleteQuestion  = 30f; //문제풀이에 주어지는 시간
    [SerializeField] float timeToShowCorrectAnswer = 10f; //정답을 보여주는 시간

    public bool loadNextQuestion;
    public float fillFraction;
    public bool isAnsweringQuestion;
    
    float timerValue;
    
    void Update()
    {
        UpdateTimer();
    }

    public void CancelTimer()
    {
        timerValue = 0;
    }

    void UpdateTimer()
    {
        timerValue -= Time.deltaTime; // 게임의 프레임마다 타이머 값이 조금씩 줄어듦, -= : 왼쪽 값에서 오른쪽 값을 뺌

        if(isAnsweringQuestion) //문제 풀이중
        {
            if(timerValue > 0)
            {
                fillFraction = timerValue / timeToCompleteQuestion; // 5/10 = 0.5
            }
            else //시간초과
            {
                isAnsweringQuestion = false; // 문제 풀이 상태를 그만둠
                timerValue = timeToShowCorrectAnswer;
            }
        }
        else
        {
            if(timerValue > 0)
            {
                fillFraction = timerValue / timeToShowCorrectAnswer;
            }
            else
            {
                isAnsweringQuestion = true;
                timerValue = timeToCompleteQuestion;
                loadNextQuestion = true;
            }
        }

        Debug.Log(isAnsweringQuestion + " :" + timerValue + " = " + fillFraction);
    }
}
