﻿using UnityEngine;
using System.Collections;

public class MainDoor : MonoBehaviour {
    GameObject RoomDoor;
	// Use this for initialization
   
    void OnMouseDown()
    {

            RoomDoor = GameObject.FindGameObjectWithTag("MainDoor");
            RoomDoor.animation.Play("door");
        

    }
}
