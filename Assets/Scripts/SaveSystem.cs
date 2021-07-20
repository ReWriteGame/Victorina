using UnityEngine;
using System.IO;


public class SaveSystem : MonoBehaviour
{
    [SerializeField] private QuestionSystem questionSystem;

    private string nameOfPath = "PathQuestion";
    private string path = "PathQuestion";

    private void Start()
    {
        path = Path.Combine(Application.persistentDataPath, nameOfPath);// для андроид

        loadFile();
    }

    public bool fileAvailable()
    {
        return File.Exists(path);
    }

    public void loadFile()
    {
        if (!fileAvailable()) return;
        questionSystem = JsonUtility.FromJson<QuestionSystem>(File.ReadAllText(path));
    }
    public void saveFile()
    {
        File.WriteAllText(path, JsonUtility.ToJson(questionSystem));
    }


    private void OnApplicationPause(bool pause)
    {
        saveFile();
    }
    private void OnApplicationQuit()
    {
        saveFile();
    }
}

