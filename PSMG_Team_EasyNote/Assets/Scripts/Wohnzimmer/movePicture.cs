using UnityEngine;
using System.Collections;

public class movePicture : MonoBehaviour {
 
    bool picMoved = false;
 
    void OnMouseDown()
    {
        if (picMoved == false)
        {
            Debug.Log("OnMouseDown");
            
            Debug.Log("Play");
            animation.Play("movePic");
            picMoved = true;
        }
       
    }
   
	
	
}

