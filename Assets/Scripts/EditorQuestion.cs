using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EditorQuestion : MonoBehaviour
{
    [SerializeField] private QuestionSystem questionSystem;

    [SerializeField] private Text text;
    void Start()
    {
       // text = GetComponent<Text>();

   
    }

    public void showAllQusetion()
    {
        text.text = questionSystem.showAllQuestions();
    }

    public void showRandomQusetion()
    {
        text.text = questionSystem.showRandomQuestion().Quest;
    }
}
