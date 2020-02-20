using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class W_Cubes : Cubes
{
    public AudioSource woosh;
    public int w = 0;
    public Animator Animat;

    public void OnMouseDown()
    {
        if (FindObjectOfType<Shape_Check>().clickable)
        {
            rotation++;
            
            
            FindObjectOfType<Shape_Check>().Move_Counter++;
            //woosh.volume = 50;
            //woosh.pitch = 2;
            //woosh.Play(0);
        }
    }
    
    public void Update()
    {
        if (tag == "Change")
        {
            rotation++;
            tag = "Cubes";
        }
        if (rotation > 4)
        {
            rotation = 1;
        }
        Animat.SetInteger("Rotation", rotation);
    }
}


