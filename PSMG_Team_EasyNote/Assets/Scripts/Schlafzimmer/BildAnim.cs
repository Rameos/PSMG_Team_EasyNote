using UnityEngine;
using System.Collections;

public class BildAnim : MonoBehaviour {

    GameObject bild;
    public bool PicOpen = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnMouseDown () {
        if (PicOpen == false)
        {
            bild = GameObject.FindGameObjectWithTag("bild");
            bild.animation.Play("BildAnim");
            PicOpen = true;
        }
	}
}
