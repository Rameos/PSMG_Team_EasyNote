﻿using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour
{
    void start()
    {
        //camSwap(1);
    }

    void Update()
    {
        if (Input.GetKey("1"))
        {
            camSwap(1);
        }
        if (Input.GetKey("2"))
        {
            
            camSwap(2);
        }

        if (Input.GetKey("3"))
        {
           
            camSwap(3);
        }
        if (Input.GetKey("4"))
        {
           
            camSwap(4);
        }

        if (Input.GetKey("4"))
        {
        
            camSwap(4);
        }

        else
        {

        }

      
    }

    void camSwap(int currentCam)
    {
        GameObject[] cameras = GameObject.FindGameObjectsWithTag("camera");

        foreach (GameObject cams in cameras)
        {
            Camera theCam = cams.GetComponent<Camera>() as Camera;
            theCam.enabled = false;
        }

        string oneToUse = "Camera" + currentCam;
        Camera usedCam = GameObject.Find(oneToUse).GetComponent<Camera>() as Camera;
        usedCam.enabled = true;
    }
}