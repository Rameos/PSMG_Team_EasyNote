using UnityEngine;
using System.Collections;

public class nachtschrank : MonoBehaviour {

    GameObject ntl;
    GameObject ntr;
    bool lopen = false;
    bool ropen = false;

	// Use this for initialization
	void Start () {
	
	}

    void OnMouseDown()
    {

        ntl = GameObject.FindGameObjectWithTag("nachtschrankTuerLinks");
        ntr = GameObject.FindGameObjectWithTag("nachtschrankTuerRechts");

        if (gameObject.tag == "nachtschrankTuerLinks" && lopen == false)
        {
            ntl.animation.Play("nachtLinksAnim");
            lopen = true;
        }

        if (gameObject.tag == "nachtschrankTuerRechts" && ropen == false)
        {
            ntr.animation.Play("nachtRechtsAnim");
            ropen = true;
        }
        

    }
}
