using UnityEngine;
using System.Collections;

public class MainDoor : MonoBehaviour {
    GameObject RoomDoor;
    GameObject rK;
    GameObject rG;
    GameObject rK2;
    GameObject kD;

    rohrClickedKlein rcK;
    rohrClickedGroß rcG;
    rotateRohr rR;
    openKasten oK;
    bool open = false;
    guiTextKeller guiKeller;
    GameObject keller;

	// Use this for initialization
    void Update()
    {
        rK = GameObject.FindGameObjectWithTag("rohrKlein");
        rcK = rK.GetComponent<rohrClickedKlein>();

        rG = GameObject.FindGameObjectWithTag("rohrGroß");
        rcG = rG.GetComponent<rohrClickedGroß>();

        rK2 = GameObject.FindGameObjectWithTag("smallRohr");
        rR = rK2.GetComponent<rotateRohr>();

        kD = GameObject.FindGameObjectWithTag("kastenDoor");
        oK = kD.GetComponent<openKasten>();

        RoomDoor = GameObject.FindGameObjectWithTag("MainDoor");

        guiKeller = RoomDoor.GetComponent<guiTextKeller>();

        keller = GameObject.FindGameObjectWithTag("keller");
       

        OpenDoor();
      
    }

    //Jeder boolsche Wert entspricht einem kleinen Teil des Gesamträtsels. Sind alle Werte true, öffnet sich die Tür. 
    void OpenDoor()
    {
        
        if (rcK.rohrKl == true &&  rR.rohrKl2 == true && rcG.rohrGr == true && oK.lightOn == true && open == false) {


        guiKeller.printHelpText("Glückwunsch! Du hast das Rätsel gelöst und\n kannst somit den nächsten Raum betreten!");
        RoomDoor.animation.Play("doorAnim");
        open = true;
        
        Invoke("LoadLevel", 5);
       
        }
    }

    //hat der Spieler das Rätsel gelöst, kommt er in den nächsten Raum.
    void LoadLevel()
    {
        Application.LoadLevel(6);
        Destroy(keller);   
        
    }

    
}
