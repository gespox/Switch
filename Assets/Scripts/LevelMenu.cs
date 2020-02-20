using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void LevelSelect(string Level)
    {
        Level = this.name;
        SceneManager.LoadScene(Level);
    }
    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }
}
