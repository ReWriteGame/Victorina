using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionSystem : MonoBehaviour
{
    private List<Question> question = new List<Question>(10);

    public List<Question> Question { get => question; private set => question = value; }

    private void Awake()
    {
        question.Add( new Question("At one time, the mafia attacked vehicles and stole cheese heads?", true));
        question.Add( new Question("Members of the American Cosa Nostra are prohibited from wearing a beard?", true));
        question.Add( new Question("Mafia diminished people in witness protection program? ", false));
        question.Add( new Question("The word 'mafia' has Arabic roots that are not associated with crime?", true));
        question.Add( new Question("Mafia was never headed by a woman?", false));
        question.Add(new Question("Mafia always carried brass knuckles in their pockets?", false));
        question.Add(new Question("The head of the mafia had a circle of confidants who passed the rite of passage by blood?", false));
        question.Add(new Question("The whole mafia wore tailcoats?", false));
        question.Add(new Question("Mafia was born because of limovs?", true));
        question.Add(new Question("Mafia was inspired by a secret Sicilian organization?", true));
        question.Add(new Question("Mafia has its own 'Ten Commandments'?", true));
        question.Add(new Question("Anyone could join the mafia?", true));
    }

    void addQuestion(string question, bool answer)
    {
        this.question.Add(new Question(question, answer));
    }

    void removeQuestion(int index)
    {
        if (index < 0) return;
        question.RemoveAt(index);
    }

    void setArr(List<Question> arr)
    {
        question = arr;
    }

    public string showAllQuestions()
    {
        string data = "";

        foreach (Question quest in question)

            data += quest.Quest + " " + $" {quest.Answer} \n\n";

        return data;
    }

    public Question showRandomQuestion()
    {
        return question[Random.Range(0, question.Count)];
    }
}
