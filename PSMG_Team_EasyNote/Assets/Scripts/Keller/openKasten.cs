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
    public int test;

    void Start()
    {
        light = GameObject.FindGameObjectWithTag("licht");
        light.light.intensity = 0;

    }



    /*public bool setTest(bool toSet) {
        test = toSet;
        Debug.Log("test in setTest: " + test);
        return test;
    }*/
    // Use this for initialization
    void OnMouseDown()
    {
        if (count == 0)
        {
          

                door = GameObject.FindGameObjectWithTag("kastenDoor");
                door.animation.Play("kasten");
                open = true;
                Debug.Log(zoom);
                count++;
                //guiText = GameObject.Find("text").guiText;
                guiText.text = "hallo";
                light.light.intensity = 1;
                Debug.Log("test: " + test);
         }
        
        if(count == 0)
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
       
            camera = GameObject.FindGameObjectWithTag("MainCamera");
            camera.animation["kamera"].speed = -1;
            camera.animation.Play("kamera");
            zoom = false;
            Debug.Log(zoom);
        
        
      
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

