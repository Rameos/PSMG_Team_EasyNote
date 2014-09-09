﻿using UnityEngine;
using System.Collections.Generic;

public class InventoryGUI : MonoBehaviour
{


    //private bool inventoryWindowToggle = false;
    private Rect inventoryWindowRect = new Rect(Screen.width - 425,Screen.height -325, 400, 300); //Screen.width - 100,Screen.height - 50,100,50
    GameObject item;

    static public Dictionary<int, string> inventoryNameDictionary = new Dictionary<int, string>(){
            {0, string.Empty},
            {1, string.Empty},
            {2, string.Empty},
            {3, string.Empty},
            {4, string.Empty},
            {5, string.Empty},
            {6, string.Empty},
            {7, string.Empty},
            {8, string.Empty},
        };



    ItemClass itemObject = new ItemClass();


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {
        //inventoryWindowToggle = GUI.Toggle(new Rect(800, 50, 100, 50), inventoryWindowToggle, "Inventory");

       // if (inventoryWindowToggle)
        
            inventoryWindowRect = GUI.Window(0, inventoryWindowRect, inventoryWindowMethod, "Inventory");
        
    }



    void inventoryWindowMethod(int windowId)
    {


        GUILayout.BeginArea(new Rect(5, 50, 395, 400));

        GUILayout.BeginHorizontal();


        if (GUILayout.Button(inventoryNameDictionary[0], GUILayout.Height(50)))
        {

           Debug.Log(inventoryNameDictionary[0]);
           Vector3 mousePos = Input.mousePosition;
           mousePos.z = 0.6f;
           Vector3 objectPos = Camera.main.ScreenToWorldPoint(mousePos);
           item = GameObject.FindGameObjectWithTag(inventoryNameDictionary[0]);
           item.renderer.enabled = true;
           item.transform.position = objectPos;
           //GameObject myObject = Instantiate(item, objectPos, Quaternion.identity);
        }
        GUILayout.Button(inventoryNameDictionary[1], GUILayout.Height(50));
        GUILayout.Button(inventoryNameDictionary[2], GUILayout.Height(50));
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Button(inventoryNameDictionary[3], GUILayout.Height(50));
        GUILayout.Button(inventoryNameDictionary[4], GUILayout.Height(50));
        GUILayout.Button(inventoryNameDictionary[5], GUILayout.Height(50));
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Button(inventoryNameDictionary[6], GUILayout.Height(50));
        GUILayout.Button(inventoryNameDictionary[7], GUILayout.Height(50));
        GUILayout.Button(inventoryNameDictionary[8], GUILayout.Height(50));
        GUILayout.EndHorizontal();

        GUILayout.EndArea();

    }



}
