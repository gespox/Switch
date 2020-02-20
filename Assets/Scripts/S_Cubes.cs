﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Cubes : Cubes
{
    public int s;
    public Animator Animat;
    public void OnMouseDown()
    {
        if (FindObjectOfType<Shape_Check>().clickable)
        {
            rotation++;
            GameObject[] gameObjs = GameObject.FindGameObjectsWithTag("Cubes");
            foreach (GameObject item in gameObjs)
            {
                if (item.transform.position.y > this.transform.position.y && item.transform.position.x == this.transform.position.x)
                {
                    item.tag = "Change";

                }
            }
            FindObjectOfType<Shape_Check>().Move_Counter++;
        }
    }

    void Update()
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
