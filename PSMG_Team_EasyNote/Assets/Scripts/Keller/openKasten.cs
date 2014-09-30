using UnityEngine;
using System.Collections;

public class openKasten : MonoBehaviour
{
    GameObject door;
    GameObject camera;
    GameObject light;
    guiTextKeller guiKeller;

    bool open = false;
    bool usedBefore = false;
    bool zoom = false;
    int count = 0;
    public  int test;
    public bool lightOn = false;
    
    

    void Start()
    {
        light = GameObject.FindGameObjectWithTag("licht");
        light.light.intensity = 0;

        door = GameObject.FindGameObjectWithTag("kastenDoor");
        guiKeller = door.GetComponent<guiTextKeller>();

    }


    // Use this for initialization
    //Wird der Kasten geöffnet, geht das Licht an und eine Benachrichtigung wird an das GUI geschickt. 
    void OnMouseDown()
    {
        if (count == 0)
        {             
                door.animation.Play("kasten");
                open = true;
                count++;
                light.light.intensity = 1;
                lightOn = true;
                guiKeller.printHelpText("Du hast den Lichtschalter gefunden!");
               
         }
        
        if(count == 0)
        {
            camera = GameObject.FindGameObjectWithTag("MainCamera");
            camera.animation.Play("kamera");
            count++;
            zoom = true;
            
        }
      }

    void OnGUI()
    {
       
            camera = GameObject.FindGameObjectWithTag("MainCamera");
            camera.animation["kamera"].speed = -1;
            camera.animation.Play("kamera");
            zoom = false;      
        
      
    }
}

