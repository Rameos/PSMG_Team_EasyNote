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

	// Use this for initialization
    void Update()
    {
        rK = GameObject.FindGameObjectWithTag("rohrKlein");
        rcK = rK.GetComponent<rohrClickedKlein>();

       // rG = GameObject.FindGameObjectWithTag("rohrGroß");
        //rcG = rG.GetComponent<rohrClickedGroß>();

        rK2 = GameObject.FindGameObjectWithTag("smallRohr");
        rR = rK2.GetComponent<rotateRohr>();

        kD = GameObject.FindGameObjectWithTag("kastenDoor");
        oK = kD.GetComponent<openKasten>();

        RoomDoor = GameObject.FindGameObjectWithTag("MainDoor");

        guiKeller = RoomDoor.GetComponent<guiTextKeller>();
       // Debug.Log("............................................." + rcG.rohrGr);

        OpenDoor();
      
    }

    void OpenDoor()
    {
        
        if (rcK.rohrKl == true &&  rR.rohrKl2 == true && oK.lightOn == true && open == false) {


        guiKeller.printHelpText("Glückwunsch! Du hast das Rätsel gelöst und kannst somit den nächsten Raum betreten!");
        RoomDoor.animation.Play("doorAnim");
        open = true;
        }
    }

   /* void Update(){

        rK = GameObject.FindGameObjectWithTag("rohrKlein");
        rohrClickedKlein rcK = rK.GetComponent<rohrClickedKlein>();
        rG = GameObject.FindGameObjectWithTag("rohrGroß");
        rohrClickedGroß rcG = rG.GetComponent<rohrClickedGroß>();
        rK2 = GameObject.FindGameObjectWithTag("smallRohr");
        rotateRohr rR = rK2.GetComponent<rotateRohr>();
        kD = GameObject.FindGameObjectWithTag("kastenDoor");
        openKasten oK = kD.GetComponent<openKasten>();

        Debug.Log("............................................." +rcG.rohrGr);
       //if (rcK.rohrKl == true &&  rR.rohrKl2 == true && oK.lightOn == true)
        
        //{
            
        //}
    }*/
   
    
}
