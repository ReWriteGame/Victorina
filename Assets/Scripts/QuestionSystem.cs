using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionSystem : MonoBehaviour
{
    private List<Question> question = new List<Question>(10);

    public List<Question> Question { get => question; private set => question = value; }

    private void Awake()
    {
        question.Add( new Question("� ��� ����� ����� �������� �� ������������ �������� � �������� ������� ����?", true));
        question.Add( new Question("������ ������������ ����� ������ ��������� ������ ������?", true));
        question.Add( new Question("����� ������� ����� � ��������� ������ ����������?", false));
        question.Add( new Question("����� ������� ����� �������� �����, ������� �� ������� � �������������?", true));
        question.Add( new Question("����� ������� �� ����������� �������?", false));
        question.Add(new Question("����� ������ ������ � �������� �������?", false));
        question.Add(new Question("����� ����� ���� ���� ���������� ��� ������� ��������� ����� ���������� ������?", false));
        question.Add(new Question("��� ����� ������ �����?", false));
        question.Add(new Question("����� ���������� ��-�� ��������?", true));
        question.Add(new Question("����� ������������� ������ ����������� ������������?", true));
        question.Add(new Question("����� ����� ���� ������� ���������?", true));
        question.Add(new Question("� ����� ��� �������� ��� ������?", true));
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
