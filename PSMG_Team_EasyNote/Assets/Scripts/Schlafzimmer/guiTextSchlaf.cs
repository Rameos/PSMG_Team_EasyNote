using UnityEngine;
using System.Collections;

public class guiTextSchlaf : MonoBehaviour {

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

    void OnGUI()
    {
        GUI.skin = GUISkin;
        

        if (clicked == false)
        {
            GUI.Label(new Rect(0, 0, 400, 150), "Mit den Tasten '1','2','3','4' und '5' kannst \ndu die Kameraperspektive verändern.");

            if (GUI.Button(new Rect(175, 120, 50, 25), "OK"))
            {
                clicked = true;
            }

        }


    }




}