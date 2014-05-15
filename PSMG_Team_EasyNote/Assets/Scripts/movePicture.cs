using UnityEngine;
using System.Collections;

public class movePicture : MonoBehaviour {

    void update()
    {
        


    }
    void OnMouseDown()
    {
        //transform.Translate(Vector3.left * 1);
        Vector3 amountToMove = new Vector3(-1, 0, 0); //  Vector3.up is short hand for (0,1,0) if you want to use that instead

            transform.position = Vector3.Lerp(transform.position, transform.position + amountToMove, 1);
        

    }
	
	
}
