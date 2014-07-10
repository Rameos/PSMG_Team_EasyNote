using UnityEngine;
using System.Collections;

public class openKasten : MonoBehaviour
{
    GameObject door;
    GameObject camera;
    GameObject light;

    bool open = false;
    bool usedBefore = false;
    bool zoom = false;
    int count = 0;

    // Use this for initialization
    void OnMouseDown()
    {
        if (zoom == true)
        {
          

                door = GameObject.FindGameObjectWithTag("kastenDoor");
                door.animation.Play("kasten");
                open = true;
                Debug.Log(zoom);
                count++;
                //light = GameObject.FindGameObjectWithTag("licht");
                
               
         }
        
        if(zoom == false)
        {
            camera = GameObject.FindGameObjectWithTag("MainCamera");
            camera.animation.Play("kamera");
            count++;
            zoom = true;
            Debug.Log(zoom);
            
        }
        /*if (open == true)
        {
            door = GameObject.FindGameObjectWithTag("kasten");
            door.animation.Play("KastenAnimClose");
            open = false;
        }*/
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width - 50, Screen.height - 50, 50, 50), "Back"))
        {
            camera = GameObject.FindGameObjectWithTag("MainCamera");
            camera.animation["kamera"].speed = -1;
            camera.animation.Play("kamera");
            zoom = false;
            Debug.Log(zoom);
        }
        
      
    }

    /*void OnMouseOver()
    {
        if (usedBefore == false)
        {

            GameObject[] cameras = GameObject.FindGameObjectsWithTag("camera");

            foreach (GameObject cams in cameras)
            {
                Camera theCam = cams.GetComponent<Camera>() as Camera;
                theCam.enabled = false;
            }

            string oneToUse = "Camera" + 2;
            Camera usedCam = GameObject.Find(oneToUse).GetComponent<Camera>() as Camera;
            usedCam.enabled = true;

            usedBefore = true;
        }
        }*/
    }

