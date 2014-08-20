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
        // Slowly rotate the object around its X axis at 1 degree/second.
        //gameObject.transform.Rotate(2*Time.deltaTime,0,0);
        // ... at the same time as spinning relative to the global 
        // Y axis at the same speed.
        //gameObject.transform.Rotate(Vector3.up * Time.deltaTime, Space.World);
        
	}

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
