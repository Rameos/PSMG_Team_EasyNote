using UnityEngine;
using System.Collections;

public class openKasten : MonoBehaviour
{
    GameObject door;
    bool open = false;
    bool usedBefore = false;

    // Use this for initialization
    void OnMouseDown()
    {
        if (open == false)
        {

            door = GameObject.FindGameObjectWithTag("kasten");
            door.animation.Play("KastenAnim");
            open = true;
        }

        /*if (open == true)
        {
            door = GameObject.FindGameObjectWithTag("kasten");
            door.animation.Play("KastenAnimClose");
            open = false;
        }*/
    }

    void OnMouseOver()
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
        }
    }

