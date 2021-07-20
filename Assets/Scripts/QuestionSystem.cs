using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionSystem : MonoBehaviour
{
    private List<Question> question = new List<Question>(10);

    public List<Question> Question { get => question; private set => question = value; }

    private void Awake()
    {
        question.Add( new Question("В своё время мафия нападала на транспортные средства и воровали головки сыра?", true));
        question.Add( new Question("Членам американской «Коза Ностра» запрещено носить бороду?", true));
        question.Add( new Question("Мафия убавала людей в программе защиты свидетелей?", false));
        question.Add( new Question("Слово «мафия» имеет арабские корни, которые не связаны с преступностью?", true));
        question.Add( new Question("Мафия никогда не возглавляла женщина?", false));
        question.Add(new Question("Мафия всегда носила в карманах кастеты?", false));
        question.Add(new Question("Глава мафии имел круг доверенных лиц которые проходили обряд посвещения кровью?", false));
        question.Add(new Question("Вся мафия носила фраки?", false));
        question.Add(new Question("Мафия зародилась из-за лимовнов?", true));
        question.Add(new Question("Мафия вдохновлялась тайной сицилийской организацией?", true));
        question.Add(new Question("Мафия имеет свои «Десять заповедей»?", true));
        question.Add(new Question("В мафию мог вступить кто угодно?", true));
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
