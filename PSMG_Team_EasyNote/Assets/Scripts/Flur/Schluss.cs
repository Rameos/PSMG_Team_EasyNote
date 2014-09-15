﻿using UnityEngine;
using System.Collections;

public class Schluss : MonoBehaviour {

    GameObject tür, schrank;
    private bool open = false;

	// Use this for initialization
	void Start () {

        tür = GameObject.FindGameObjectWithTag("türFlur");
        //schrank = GameObject.FindGameObjectWithTag("korpus");
      
      
	}
	
	// Update is called once per frame
	void Update () {
        gelöst();
	}

    void gelöst()
    {
        HebelRaetsel hebelRaetsel = Camera.main.GetComponent<HebelRaetsel>();
        
      
        if (hebelRaetsel.hasWon == true)
        {
            if (open == false)
            {

                Camera.main.transform.position = new Vector3(-1.28f, 1.24f, 0.69f);
                Camera.main.transform.rotation = new Quaternion(17.4f, 94.6f, -13.74f, 126f);
                Debug.Log("Play animation");
               // schrank.animation.Play("shutDoors");
                tür.animation.Play("door");
                open = true;
                Application.LoadLevel(10);

            }
        }
        
    }
}