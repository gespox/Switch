using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.IO;


public class MainMenu : MonoBehaviour
{
    string Path;
    string Level;
    public bool Tutor = true;
    
    void CreateLog ()
    {
        Path = Application.persistentDataPath + "/CL.txt";
        if (!System.IO.File.Exists(Path))
        {
            System.IO.File.WriteAllText(Path, "Level 1");
        }
    }
    void ReadLog()
    {
        
        System.IO.StreamReader reader = new System.IO.StreamReader(Path);
        Level = reader.ReadToEnd();
        reader.Close();
    }
    public void Levels()
    {
        SceneManager.LoadScene("Levels");
    }


    public void PlayGame()
    {
        SceneManager.LoadScene(Level);
        
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    private void Start()
    {

        CreateLog();
        ReadLog();
        if(Tutor)
        {
            
        }

    }
    public void ResetLevel()
    {
        System.IO.File.WriteAllText(Application.persistentDataPath + "/CL.txt", "Level 1");
        
        Level = "Level 1";
    }
    
    public void Toggle_Change(bool Value)
    {
        Tutor = Value;
        Tutorial.tutorial = Value;

    }
}
