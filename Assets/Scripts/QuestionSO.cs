using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]
public class QuestionSO : ScriptableObject
{
    [TextArea(2,6)] // TextArea(최소 줄 수,최대 줄 수): inspector 안의 텍스트 상자 크기를 조정
    [SerializeField] string question = "Enter new question text here";
    [SerializeField] string[] answers = new string[4];
    [SerializeField] int correctAnswerIndex;

    public string GetQuestion() // method가 string을 반환
    {
        return question;
    } // question에 대한 읽기 전용 액세스

    public string GetAnswer(int index)
    {
        return answers[index];
    }

    public int GetCorrectAnswerIndex()
    {
        return correctAnswerIndex;
    }
}
