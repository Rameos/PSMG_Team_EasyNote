﻿using UnityEngine;
using System.Collections.Generic;

public class InventoryGUI : MonoBehaviour
{

    private Rect inventoryWindowRect = new Rect(Screen.width - 425, Screen.height - 325, 400, 250); //Screen.width - 100,Screen.height - 50,100,50
    //private bool inventoryWindowToggle = false;

    int windowX = Screen.width - 425;
    int windowY = Screen.height - 325;
    string match = "";


    GameObject item, hebel, hebelDublicate;

    bool toggleVariable;
    public bool dragHebel = false;
    bool toggle0, toggle1, toggle2, toggle3 = false;
    public GUISkin MyButton;

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

        inventoryWindowRect = GUI.Window(0, inventoryWindowRect, inventoryWindowMethod, "Inventar");
        //getActiveToggle();

    }



    void inventoryWindowMethod(int windowId)
    {


        GUILayout.BeginArea(new Rect(5, 50, 395, 400));

        GUILayout.BeginHorizontal();

        if (toggle0 = GUI.Toggle(new Rect(10, 70, 160, 50), toggle0, inventoryNameDictionary[0], "button"))
        {
            toggle0 = true;

        }
        else
        {
            toggle0 = false;
        }


        if (toggle1 = GUI.Toggle(new Rect(200, 70, 160, 50), toggle1, inventoryNameDictionary[1], "button"))
        {
            toggle1 = true;
        }
        else
        {
            toggle1 = false;
        }
        GUILayout.EndHorizontal();


        GUILayout.BeginHorizontal();
        if (toggle2 = GUI.Toggle(new Rect(10, 140, 160, 50), toggle2, inventoryNameDictionary[2], "button"))
        {
            toggle2 = true;
        }
        else
        {
            toggle2 = false;
        }


        if (toggle3 = GUI.Toggle(new Rect(200, 140, 160, 50), toggle3, inventoryNameDictionary[3], "button"))
        {
            toggle3 = true;
        }
        else
        {
            toggle3 = false;
        }

        GUILayout.EndHorizontal();
        //if (GUILayout.Button(inventoryNameDictionary[0], GUILayout.Height(50)))
        //{

        //   Debug.Log(inventoryNameDictionary[0]);
        //   Vector3 mousePos = Input.mousePosition;
        //   mousePos.z = 0.6f;
        //   Vector3 objectPos = Camera.main.ScreenToWorldPoint(mousePos);
        //   item = GameObject.FindGameObjectWithTag(inventoryNameDictionary[0]);
        //   item.renderer.enabled = true;
        //   item.transform.position = objectPos;
        //   //GameObject myObject = Instantiate(item, objectPos, Quaternion.identity);
        //}



        GUILayout.BeginHorizontal();
        if (GUILayout.Button("Kombinieren", GUILayout.Height(50)))
        {

            getActiveToggle();
            testMatch();
            //Debug.Log();
        }

        if (GUILayout.Button("Benutzen", GUILayout.Height(50)))
        {
            getItem();
           
        }



        GUILayout.EndHorizontal();

        GUILayout.EndArea();

    }


    void getActiveToggle()
    {
        if (toggle0 && toggle1)
        {
            match = inventoryNameDictionary[0] + inventoryNameDictionary[1];
            Debug.Log("" + inventoryNameDictionary[0] + inventoryNameDictionary[1]);
        }
        if (toggle0 && toggle2)
        {
            Debug.Log("" + inventoryNameDictionary[0] + inventoryNameDictionary[2]);
            match = inventoryNameDictionary[0] + inventoryNameDictionary[2];
        }
        if (toggle0 && toggle3)
        {
            Debug.Log("" + inventoryNameDictionary[0] + inventoryNameDictionary[3]);
            match = inventoryNameDictionary[0] + inventoryNameDictionary[3];
        }
        if (toggle1 && toggle2)
        {
            Debug.Log("" + inventoryNameDictionary[1] + inventoryNameDictionary[2]);
            match = inventoryNameDictionary[1] + inventoryNameDictionary[2];
        }
        if (toggle1 && toggle3)
        {
            Debug.Log("" + inventoryNameDictionary[1] + inventoryNameDictionary[3]);
            match = inventoryNameDictionary[1] + inventoryNameDictionary[3];
        }
        if (toggle2 && toggle3)
        {
            Debug.Log("" + inventoryNameDictionary[2] + inventoryNameDictionary[3]);
            match = inventoryNameDictionary[2] + inventoryNameDictionary[3];
        }

        if ((toggle0 && toggle1 && toggle2) || (toggle0 && toggle1 && toggle3) || (toggle0 && toggle3 && toggle2) || (toggle3 && toggle1 && toggle2) || (toggle0 && toggle1 && toggle2 && toggle3))
        {
            Debug.Log("Nur zwei gleichzeitig");
        }
        if (!toggle0 && !toggle1 && !toggle2 && !toggle3)
        {
            Debug.Log("Wähle zwei Objekte aus");
        }


    }

    void testMatch()
    {
        if (match.Equals("SägeSpazierstock") || match.Equals("SpazierstockSäge"))
        {
            //Kombinieren
            Debug.Log("Richtige Kombi");
            audio.Play();
            if (inventoryNameDictionary[2] == string.Empty)
            {
                inventoryNameDictionary[2] = "Kurzer Stock";
            }
            else
            {
                inventoryNameDictionary[3] = "Kurzer Stock";
            }

        }

        else
        {
            Debug.Log("Falsche Kombi");
            //fehlermeldung
        }
    }

    void getItem()
    {
        MovingCamera movCam = Camera.main.GetComponent<MovingCamera>();

        if ((inventoryNameDictionary[2].Equals("Kurzer Stock") && toggle2) || (inventoryNameDictionary[3].Equals("Kurzer Stock") && toggle3))
        {
            Debug.Log(movCam.cameraPos);
            if (movCam.cameraPos.Equals("Schrank"))
            {
                Debug.Log(movCam.cameraPos);
                dragHebel = true;
                //Vector3 mousePos = Input.mousePosition;
                //mousePos.z = 0.6f;
                //Vector3 objectPos = Camera.main.ScreenToWorldPoint(mousePos);
                item = GameObject.FindGameObjectWithTag("hebelDub");
                item.renderer.enabled = true;
                //item.transform.position = objectPos;

            }

            else
            {

            }

        }
    }

}
