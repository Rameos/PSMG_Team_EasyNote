﻿using UnityEngine;
using System.Collections;

public class DeactivateUVAK : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void Update()
    {
        if (Input.GetKey("u"))
        {
            Application.LoadLevel(22);
        }
    }
}