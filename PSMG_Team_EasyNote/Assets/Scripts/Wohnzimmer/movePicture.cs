using UnityEngine;
using System.Collections;

public class movePicture : MonoBehaviour {
    GameObject pic;
    bool picMoved = false;
 
    void OnMouseDown()
    {
        if (picMoved == false)
        {
            Debug.Log("OnMouseDown");
            pic = GameObject.FindGameObjectWithTag("Bild");
            Debug.Log("Play");
            pic.animation.Play("movePicture");
            picMoved = true;
        }
       
    }
   
	
	
}

