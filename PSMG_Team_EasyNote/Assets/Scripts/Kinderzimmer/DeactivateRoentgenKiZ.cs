﻿using UnityEngine;
using System.Collections;

using UnityEngine;
using System.Collections;
using iViewX;

public class DeactivateRoentgenKiZ : MonoBehaviour {
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("r"))
        {
            Application.LoadLevel(9);
        }
    }
}