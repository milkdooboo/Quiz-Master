using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    int correctAnswers = 0; //얼마나 많이 맞혔는지
    int questionsSeen = 0; // 얼마나 많은 문제를 봤는지

    public int GetCorrectAnswers()
    {
        return correctAnswers;
    }

    public void IncrementCorrectAnswers()
    {
        correctAnswers++;
    }

    public int GetQuestionSeen()
    {
        return questionsSeen;
    }

    public void IncrementQuestionsSeen()
    {
        questionsSeen++;
    }

    public int CalculateScore()
    {
        return Mathf.RoundToInt(correctAnswers / (float)questionsSeen * 100); // 3 / 4.0
    }
}
