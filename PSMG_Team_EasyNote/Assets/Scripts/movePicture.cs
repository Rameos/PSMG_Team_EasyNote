using UnityEngine;
using System.Collections;

public class movePicture : MonoBehaviour {
    GameObject pic;
 
    void OnMouseDown()
    {
        Debug.Log("OnMouseDown");
         pic = GameObject.FindGameObjectWithTag("Bild");
         Debug.Log("Play");
         pic.animation.Play("move");

    }
   
	
	
}

