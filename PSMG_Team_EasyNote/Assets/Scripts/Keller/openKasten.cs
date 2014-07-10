using UnityEngine;
using System.Collections;

public class openKasten : MonoBehaviour
{
    GameObject door;
    GameObject camera;
    GameObject light;

    bool open = false;
    bool usedBefore = false;
    int count = 0;

    // Use this for initialization
    void OnMouseDown()
    {
        if (count == 1)
        {
          

                door = GameObject.FindGameObjectWithTag("kastenDoor");
                door.animation.Play("kasten");
                open = true;
                Debug.Log("blalalalalala");
                count++;
                light = GameObject.FindGameObjectWithTag("licht");
                
               
            }
        
        else if(count == 0)
        {
            camera = GameObject.FindGameObjectWithTag("MainCamera");
            camera.animation.Play("kamera");
            count++;
        }
        /*if (open == true)
        {
            door = GameObject.FindGameObjectWithTag("kasten");
            door.animation.Play("KastenAnimClose");
            open = false;
        }*/
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

