using UnityEngine;
using System.Collections;

public class rotateRohr : MonoBehaviour {

    GameObject sRohr;
    public bool rohrKl2 = false;

    GameObject kasten;
    guiTextKeller guiKeller;
    openKasten openKasten;


	// Use this for initialization
	void Start () {
        sRohr = GameObject.FindGameObjectWithTag("smallRohr");       
        guiKeller = sRohr.GetComponent<guiTextKeller>();

        kasten = GameObject.FindGameObjectWithTag("kastenDoor");
        openKasten = kasten.GetComponent<openKasten>();
	}
	
	// Update is called once per frame
	void Update () {
        
        
	}

    //Bei Klick wird die Animation ausgeführt und der Wert auf true gesetzt.
    void OnMouseDown()
    {
        if (openKasten.lightOn == true)
        {
            sRohr.animation.Play("smallRohrAnim");
            sRohr.audio.Play();
            rohrKl2 = true;
            guiKeller.printHelpText("Du hast das Rohr wieder in die richtige Richtung gedreht!");
        }
    }

}
