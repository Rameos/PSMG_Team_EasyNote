﻿using UnityEngine;
using System.Collections;

public class BackToNormal : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("n"))
        {
            Application.LoadLevel(4);
        }
    }
}
