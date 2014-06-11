using UnityEngine;
using System.Collections;

public class MainDoor : MonoBehaviour {
    GameObject RoomDoor;
	// Use this for initialization
   
    void OnMouseOver()
    {
       
            Debug.Log("OnMouseOver");
            RoomDoor = GameObject.FindGameObjectWithTag("MainDoor");
            RoomDoor.animation.Play("MDAnim");
        

    }
}
