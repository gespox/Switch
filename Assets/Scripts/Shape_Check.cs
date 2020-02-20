using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.IO;

public class Shape_Check : Cubes
{
    public Text moveText,LevelN;
    public int Move_Counter , S_Counter;
    public GameObject[] Obj;
    public GameObject Nbutton, Goal;
    public bool clickable = true, start = false;
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    private void Start()
    {
        
        Obj = GameObject.FindGameObjectsWithTag("Cubes");
        Goal = GameObject.Find("Cube_Goal");
        LevelN.text = SceneManager.GetActiveScene().name;
        System.IO.File.WriteAllText(Application.persistentDataPath + "/CL.txt", SceneManager.GetActiveScene().name);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }
        if (Input.GetMouseButtonDown(0))
        {
            moveText.text = Move_Counter.ToString();
            start = true;
        }
        if (start)
        {


            foreach (GameObject Obj in Obj)
            {

                if (Goal.transform.rotation.eulerAngles == Obj.transform.rotation.eulerAngles)
                {
                    S_Counter++;
                }
            }
            if (Obj.Length == S_Counter)
            {
                Nbutton.SetActive(true);
                clickable = false;
            }
            else
            {
                S_Counter = 0;

            }
        }
    }
}
