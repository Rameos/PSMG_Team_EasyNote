using UnityEngine;
using System.Collections.Generic;

public class InventarGUI : MonoBehaviour
{

    private Rect inventoryWindow = new Rect(Screen.width - 425, Screen.height - 325, 400, 250); //Screen.width - 100,Screen.height - 50,100,50
    //private bool inventoryWindowToggle = false;

    int windowX = Screen.width - 425;
    int windowY = Screen.height - 325;
    string kombi = "";
    string message = "Durch Klicken auf Dinge kannst du sie ins Inventar legen. \nNachdem du zwei ausgewählt hast, kannst du sie miteinander kombinieren.";


    GameObject objekt, hebel, hebelDublicate;

    bool toggleVariable;
    public bool dragItem = false;
    bool button0, button1, button2, button3 = false;
    public GUISkin MyButton;

    static public Dictionary<int, string> inventoryNameDictionaryW = new Dictionary<int, string>(){
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



    ItemClassW itemObject = new ItemClassW();


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
        GUI.Label(new Rect(Screen.width / 2 - 200, 0, 500, 100), message);
        //inventoryWindowToggle = GUI.Toggle(new Rect(800, 50, 100, 50), inventoryWindowToggle, "Inventory");

        // if (inventoryWindowToggle)

        inventoryWindow = GUI.Window(0, inventoryWindow, inventoryWindowMethodW, "Inventar");
        //getActiveToggle();

    }



    void inventoryWindowMethodW(int windowId)
    {


        GUILayout.BeginArea(new Rect(5, 50, 395, 400));

        GUILayout.BeginHorizontal();

        if (button0 = GUI.Toggle(new Rect(10, 70, 160, 50), button0, inventoryNameDictionaryW[0], "button"))
        {
            button0 = true;

        }
        else
        {
            button0 = false;
        }


        if (button1 = GUI.Toggle(new Rect(200, 70, 160, 50), button1, inventoryNameDictionaryW[1], "button"))
        {
            button1 = true;
        }
        else
        {
            button1 = false;
        }
        GUILayout.EndHorizontal();


        GUILayout.BeginHorizontal();
        if (button2 = GUI.Toggle(new Rect(10, 140, 160, 50), button2, inventoryNameDictionaryW[2], "button"))
        {
            button2 = true;
        }
        else
        {
            button2 = false;
        }


        if (button3 = GUI.Toggle(new Rect(200, 140, 160, 50), button3, inventoryNameDictionaryW[3], "button"))
        {
            button3 = true;
        }
        else
        {
            button3 = false;
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

            getActiveToggleW();
            testKombi();
            trueAufhebenW();
            //Debug.Log();
        }

        if (GUILayout.Button("Benutzen", GUILayout.Height(50)))
        {
            getItemW();
            trueAufhebenW();

        }



        GUILayout.EndHorizontal();

        GUILayout.EndArea();

    }


    void getActiveToggleW()
    {
        if (button0 && button1)
        {
            kombi = inventoryNameDictionaryW[0] + inventoryNameDictionaryW[1];


        }
        if (button0 && button2)
        {
            kombi = inventoryNameDictionaryW[0] + inventoryNameDictionaryW[2];

        }
        if (button0 && button3)
        {
            kombi = inventoryNameDictionaryW[0] + inventoryNameDictionaryW[3];

        }
        if (button1 && button2)
        {
            kombi = inventoryNameDictionaryW[1] + inventoryNameDictionaryW[2];

        }
        if (button1 && button3)
        {

            kombi = inventoryNameDictionaryW[1] + inventoryNameDictionaryW[3];

        }
        if (button2 && button3)
        {

            kombi = inventoryNameDictionaryW[2] + inventoryNameDictionaryW[3];

        }

        if ((button0 && button1 && button2) || (button0 && button1 && button3) || (button0 && button3 && button2) || (button3 && button1 && button2) || (button0 && button1 && button2 && button3))
        {
            Debug.Log("Nur zwei gleichzeitig");
            message = "Du kannst nur zwei Dinge kombinieren";

        }
        if (!button0 && !button1 && !button2 && !button3)
        {
            Debug.Log("Wähle zwei Objekte aus");
            message = "Wähle zwei Objekte aus";

        }


    }

    void testKombi()
    {
        if (kombi.Equals("SägeSpazierstock") || kombi.Equals("SpazierstockSäge"))
        {
            //Kombinieren

            audio.Play();
            if (inventoryNameDictionaryW[2] == string.Empty)
            {
                inventoryNameDictionaryW[2] = "Kurzer Stock";
            }
            else
            {
                inventoryNameDictionaryW[3] = "Kurzer Stock";
            }
            message = "Du hast ein neues Objekt entdeckt";
        }

        else
        {
            message = "Das funktioniert nicht";
            Debug.Log("Falsche Kombi");
            //fehlermeldung
        }
    }

    void getItemW()
    {
        MovingCamera movCam = Camera.main.GetComponent<MovingCamera>();

        if ((inventoryNameDictionaryW[2].Equals("Kurzer Stock") && button2) || (inventoryNameDictionaryW[3].Equals("Kurzer Stock") && button3))
        {
            Debug.Log(movCam.cameraPos);
            if (movCam.cameraPos.Equals("Schrank"))
            {

                dragItem = true;
                //Vector3 mousePos = Input.mousePosition;
                //mousePos.z = 0.6f;
                //Vector3 objectPos = Camera.main.ScreenToWorldPoint(mousePos);
                objekt = GameObject.FindGameObjectWithTag("hebelDub");
                objekt.renderer.enabled = true;
                //item.transform.position = objectPos;

            }

            else
            {

            }

        }
    }


    void trueAufhebenW()
    {
        button0 = false;
        button1 = false;
        button2 = false;
        button3 = false;
    }
}
