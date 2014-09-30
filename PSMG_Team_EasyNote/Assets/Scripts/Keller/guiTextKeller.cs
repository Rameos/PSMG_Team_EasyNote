using UnityEngine;
using System.Collections;

public class guiTextKeller : MonoBehaviour {

    bool showLabel = false;
    string helpText;
    public GUISkin GUISkin;
	// Use this for initialization
	void Start () {
	
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
        if (showLabel)
        {
           
            GUI.Label(new Rect(Screen.width / 2 - 200, 0, 500, 100), helpText);
        }
        else
        {
            GUI.Label(new Rect(0,0,0,0), "");
        }

    }

    //Erhält verschiedene Benachrichtigungen aus anderen Skripten, die in OnGUI verwendet und dann im Screen eingeblendet werden
    public void printHelpText(string help)
    {
        helpText = help;
        Invoke("ToggleLabel", 1);
        Invoke("ToggleLabel", 3);
    }

    
}