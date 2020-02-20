using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour
{
    public GameObject TutorialText1, TutorialText2, TutorialImage1, TutorialImage2;
    public GameObject Cube;
    public static bool tutorial = true;
    public Animator Finger;

    public int counter=0;

    void TutorialB()
    {
        TutorialImage1.SetActive(true);
        TutorialText1.SetActive(true);
        if (Input.GetMouseButtonDown(0))
        {
            TutorialImage1.SetActive(false);
            TutorialText1.SetActive(false);
            counter++;
        } 
        
    }
    void TutorialG()
    {
        Finger.SetInteger("tutor", 1);
        TutorialImage1.SetActive(true);
        TutorialText1.SetActive(true);
        if (Input.GetMouseButtonDown(0))
        {
            TutorialImage1.SetActive(false);
            TutorialText1.SetActive(false);
            counter++;
        }
    }
    void TutorialW()
    {
        TutorialImage1.SetActive(true);
        TutorialText1.SetActive(true);
        if (Input.GetMouseButtonDown(0))
        {
            counter++;
            
                     
        }
    }
    void TutorialW2()
    {
        
        Finger.SetInteger("tutor", counter);
        TutorialText1.SetActive(false);
        TutorialText2.SetActive(true);
        TutorialImage2.SetActive(true);
        if (Input.GetMouseButtonDown(0))
        {
            counter++;
        }
        
    }
    void TutorialS()
    {
        Finger.SetInteger("tutor", 2);
        TutorialImage1.SetActive(true);
        TutorialText1.SetActive(true);
        if (Input.GetMouseButtonDown(0))
        {
            TutorialImage1.SetActive(false);
            TutorialText1.SetActive(false);
            counter++;
        }
    }
    void TutorialEnd()
    {
        TutorialImage1.SetActive(false);
        TutorialImage2.SetActive(false);
        TutorialText1.SetActive(false);
        TutorialText2.SetActive(false);
    }
    void Start()
    {
        Cube = GameObject.Find("Cube_W");

        

        if (SceneManager.GetActiveScene().name == "Level 1")
        {
            counter = 0;
        }
        else if (SceneManager.GetActiveScene().name == "Level 3")
        {
            counter = 5;
        }
        else if (SceneManager.GetActiveScene().name == "Level 5")
        {
            counter = 10;
        }
        else if (SceneManager.GetActiveScene().name == "Level 9")
        {
            counter = 15;
        }
        
    }

    
    void Update()
    {

        if (tutorial)
        {


            switch (counter)
            {
                case 0:
                    TutorialW();
                    break;
                case 1:
                    if (Cube.transform.rotation.eulerAngles.y == 0)
                    {
                        TutorialW2();
                    }

                    break;
                case 2:
                    TutorialEnd();
                    break;
                case 5:
                    TutorialB();
                    break;
                case 6:
                    TutorialEnd();
                    break;
                case 10:
                    TutorialG();
                    break;
                case 11:
                    TutorialEnd();
                    break;
                case 15:
                    TutorialS();
                    break;
                case 16:
                    TutorialEnd();
                    break;
                default:
                    break;
            }

        }    
        
    }
}
