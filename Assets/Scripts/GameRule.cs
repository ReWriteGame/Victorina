using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameRule : MonoBehaviour
{
    [SerializeField] private Text question;
    private Question quest;

    [SerializeField] private GameObject win;
    [SerializeField] private GameObject lose;
    [SerializeField] private QuestionSystem questionSystem;


    [SerializeField] private Admob admob;
    [SerializeField] private int adFrequency = 2;


    private bool choise;
    void Start()
    {
        randomQuestion();
        
    }
    public void setAnswer(bool myChoice)
    {
        win.SetActive(false);
        lose.SetActive(false);
        choise = myChoice;
        checkMyChoice();
    }

    public void randomQuestion()
    {
        quest = questionSystem.showRandomQuestion();
        showQuestion();

        checkCountForAdmob();
        win.SetActive(false);
        lose.SetActive(false);
    }

    public void showQuestion()
    {
        question.text = $"{quest.Quest}";
    }

    public void checkMyChoice()
    {
        if (choise == quest.Answer) win.SetActive(true);
        else lose.SetActive(true);
    }

    void checkCountForAdmob()
    {
        if(Random.Range(0, adFrequency) == 0)
            admob.show();    
    }
}
