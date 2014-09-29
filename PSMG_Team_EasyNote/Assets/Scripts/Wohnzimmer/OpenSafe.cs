using UnityEngine;
using System.Collections;
using System.Text.RegularExpressions;

public class OpenSafe : MonoBehaviour
{
    GameObject bild;
    bool safeClicked = false;
    bool showWindow = true;
    string input = "";
    string solution = "7351";
    Rect inventoryWindow = new Rect(Screen.width / 2 - 100, Screen.height / 2 - 100, 200, 100);

    // Use this for initialization
    void Start()
    {
        bild = GameObject.FindGameObjectWithTag("Bild");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {

        movePicture pic = bild.GetComponent<movePicture>();

        if (pic.picMoved == true)
        {
            safeClicked = true;

        }
    }

    void OnGUI()
    {

        if (showWindow)
        {
            if (safeClicked)
            {

                GUI.BeginGroup(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 50, 200, 120));

                GUI.Box(new Rect(0, 0, 200, 230), "Gib die Geheimzahl ein:");
                input = GUI.TextField(new Rect(80, 30, 50, 30), input, 4);  //Screen.width / 2 - 15, Screen.height / 2 - 70, 50, 30
                input = Regex.Replace(input, "[^0-9]", "");


                if (GUI.Button(new Rect(10, 70, 80, 30), "Enter"))
                {
                    vergleicheZahlen();
                }
                if (GUI.Button(new Rect(100, 70, 80, 30), "Abbrechen"))
                {
                    showWindow = false;
                }

                GUI.EndGroup();

            }
        }

    }



    void vergleicheZahlen()
    {

        if (input.Equals(solution))
        {
            //Öffne safe
            showWindow = false;

            animation.Play("safe");
        }
        else
        {

        }
    }
}