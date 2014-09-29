using UnityEngine;
using System.Collections.Generic;

public class InventarGUI : MonoBehaviour
{

    private Rect inventoryWindow = new Rect(Screen.width - 425, Screen.height - 325, 400, 250);

    bool showInventory = false;
    int windowX = Screen.width - 425;
    int windowY = Screen.height - 325;
    string kombi = "";
    string message = "Durch Klicken auf Dinge kannst du sie ins Inventar legen. \nNachdem du zwei ausgewählt hast, kannst du sie miteinander kombinieren.";


    GameObject objekt, hebel, hebelDublicate;

    bool toggleVariable;
    public bool dragHammer = false;
    public bool dragSchlüssel = false;
    public bool dragRemote = false;
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


        showInventory = GUI.Toggle(new Rect(Screen.width / 2 - 300, 25, 100, 50), showInventory, "Inventar");
        if (showInventory)
        {
            inventoryWindow = GUI.Window(0, inventoryWindow, inventoryWindowMethodW, "Inventar");
        }


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


        GUILayout.BeginHorizontal();


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

            message = "Du kannst nur zwei Dinge kombinieren";

        }
        if (!button0 && !button1 && !button2 && !button3)
        {

            message = "Wähle zwei Objekte aus";

        }


    }

    void testKombi()
    {
        if (kombi.Equals("BatterieFernbedienung") || kombi.Equals("FernbedienungBatterie"))
        {
            //Kombinieren


            if (inventoryNameDictionaryW[2] == string.Empty)
            {
                inventoryNameDictionaryW[2] = "funktionierende Fernbedienung";
            }
            else
            {
                inventoryNameDictionaryW[3] = "funktionierende Fernbedienung";
            }
            message = "Du hast ein neues Objekt entdeckt";
        }



        else
        {
            message = "Das funktioniert nicht";

        }
    }

    void getItemW()
    {
        MovementCamera movCam = Camera.main.GetComponent<MovementCamera>();

        if ((inventoryNameDictionaryW[0].Equals("Hammer") && button0) || (inventoryNameDictionaryW[1].Equals("Hammer") && button1))
        {

            if (movCam.camPos.Equals("Wand"))
            {

                dragHammer = true;
                objekt = GameObject.FindGameObjectWithTag("hammerDub");
                objekt.renderer.enabled = true;


            }

            else
            {

            }

        }


        if ((inventoryNameDictionaryW[1].Equals("Schlüssel") && button1) || (inventoryNameDictionaryW[2].Equals("Schlüssel") && button2))
        {

            if (movCam.camPos.Equals("Kommode") || movCam.camPos.Equals("TV"))
            {

                dragSchlüssel = true;
                objekt = GameObject.FindGameObjectWithTag("schlüsselDub");
                objekt.renderer.enabled = true;
            }

            else
            {

            }

        }


        if ((inventoryNameDictionaryW[2].Equals("Fernbedienung") && button2) || (inventoryNameDictionaryW[3].Equals("Fernbedienung") && button3))
        {

            if (movCam.camPos.Equals("Kommode") || movCam.camPos.Equals("TV"))
            {

                dragRemote = true;
                objekt = GameObject.FindGameObjectWithTag("fernDub");
                objekt.renderer.enabled = true;


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
