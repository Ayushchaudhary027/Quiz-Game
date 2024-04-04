using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]
public class QuestionSO : ScriptableObject
{
    [TextArea(2,6)]
    [SerializeField] string Question = "Enter new question text here";
    [SerializeField] string[] answers = new string[4];
    [SerializeField] int correctAnswerIndex;

    public string GetQuestion()
    {
        return Question;
    }

    public int GetCorrectAnswerIndex() 
    { 
        return correctAnswerIndex; 
    }

    public string GetAnswer(int index)
    {
        return answers[index];
    }

}
