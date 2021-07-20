using System;

[Serializable]
public class Question 
{
    private string quest;
    private bool answer;

    public bool Answer { get => answer; set => answer = value; }
    public string Quest { get => quest; set => quest = value; }

    public Question(string question, bool answer)
    {
        this.quest = question;
        this.answer = answer;
    }

  
}
