using UnityEngine;
using System.Collections;

public class BildAnim : MonoBehaviour {

    GameObject bild;
    bool open = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnMouseDown () {
        if (open == false)
        {
            bild = GameObject.FindGameObjectWithTag("bild");
            bild.animation.Play("BildAnim");
            open = true;
        }
	}
}
