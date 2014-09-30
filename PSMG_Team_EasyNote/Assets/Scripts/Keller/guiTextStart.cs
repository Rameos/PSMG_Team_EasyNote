using UnityEngine;
using System.Collections;

public class guiTextStart : MonoBehaviour {

    bool showLabel = false;
    string helpText;
    public GUISkin GUISkin;

    private bool clicked = false;
    private bool shown = false;
    // Use this for initialization
    void Start()
    {
        Invoke("ToggleLabel", 1);
        Invoke("ToggleLabel", 6);
    }

    // Update is called once per frame
    void Update()
    {
        OnGUI();
    }

    public void ToggleLabel()
    {
        showLabel = !showLabel;
    }

    //Text, der zu Beginn dargestellt wird
    void OnGUI()
    {
        GUI.skin = GUISkin;
        if (showLabel)
        {

            GUI.Label(new Rect(Screen.width / 2 - 200, 0, 500, 100), "In diesem Raum ist es ziemlich düster...\nDu solltest erst einmal für etwas Licht sorgen...");
           
        }
        else
        {
            GUI.Label(new Rect(0, 0, 0, 0), "");
        }

        if (clicked == false)
        {
            GUI.Label(new Rect(0, 0, 400, 150), "Mit den Tasten '1' und '2' kannst \ndu die Kameraperspektive verändern.\nDurch klick auf einzelne Gegenstände,\nkannst du diese bewegen.");
            
            if (GUI.Button(new Rect(175, 120, 50, 25), "OK"))
            {
                clicked = true;
            }
        
        }
        
        
    }

   


}