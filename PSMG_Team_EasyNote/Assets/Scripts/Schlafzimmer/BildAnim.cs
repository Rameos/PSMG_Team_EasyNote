using UnityEngine;
using System.Collections;

public class BildAnim : MonoBehaviour {

    GameObject bild;
    GameObject truhe;
    public bool PicOpen = false;
    Wecker wecker;

	// Use this for initialization
	void Start () {
	    
	}

    void Update()
    {
        GameObject zb = GameObject.FindGameObjectWithTag("ziffernblatt");
        wecker = zb.GetComponent<Wecker>(); 

    }

    //Durch Klick auf das jeweilige GameObject wird eine Animation abgespielt.
	void OnMouseDown () {
        if (PicOpen == false)
        {
            if (wecker.ringing == true)
            {
                bild = GameObject.FindGameObjectWithTag("bild");
                bild.animation.Play("BildAnim");
                PicOpen = true;
            }
        }
        if (gameObject.tag == "truhe")
        {
            truhe = GameObject.FindGameObjectWithTag("truhe");
            truhe.animation.Play("truheAnim");
        }
	}
}
