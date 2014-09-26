using UnityEngine;
using System.Collections;
using System.Text.RegularExpressions;

public class OpenSafe : MonoBehaviour
{

    bool safeClicked = false;
    string input = "";
    string solution = "7351";
    Rect inventoryWindow = new Rect(Screen.width / 2 - 100, Screen.height / 2 - 100, 200, 100);

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        safeClicked = true;

    }

    void OnGUI()
    {

        if (safeClicked)
        {

            GUI.BeginGroup(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 50, 200, 120));
            // All rectangles are now adjusted to the group. (0,0) is the topleft corner of the group.

            // We'll make a box so you can see where the group is on-screen.
            GUI.Box(new Rect(0, 0, 200, 230), "Gib die Geheimzahl ein:");
            input = GUI.TextField(new Rect(80, 30, 50, 30), input, 4);  //Screen.width / 2 - 15, Screen.height / 2 - 70, 50, 30
            input = Regex.Replace(input, "[^0-9]", "");


            if (GUI.Button(new Rect(60, 70, 80, 30), "Enter"))
            {
                vergleicheZahlen();
            }

            // End the group we started above. This is very important to remember!
            GUI.EndGroup();


            

            //inventoryWindow = GUI.Window(0, inventoryWindow, inventoryWindowMethod, "Gib die Geheimzahl ein:");
        }

    }




    void inventoryWindowMethod(int windowId)
    {

       GUI.BeginGroup (new Rect (Screen.width / 2 - 50, Screen.height / 2 - 50, 100, 100));
        // All rectangles are now adjusted to the group. (0,0) is the topleft corner of the group.
    
        // We'll make a box so you can see where the group is on-screen.
        GUI.Box (new Rect (0,0,100,100), "Group is here");
        GUI.Button (new Rect (10,40,80,30), "Click me");
    
        // End the group we started above. This is very important to remember!
        GUI.EndGroup ();
    }


    void vergleicheZahlen()
    {

        if(input.Equals(solution)){
            //Öffne safe
            Debug.Log("Richtiger Code");
        }
    }
}