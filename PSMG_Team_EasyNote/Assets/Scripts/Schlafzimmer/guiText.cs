using UnityEngine;
using System.Collections;

public class guiText : MonoBehaviour {
    bool showLabel = false;
  
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        OnGUI();
	}

    public void ToggleLabel()
    {
        showLabel = !showLabel;
    }

    void OnGUI()
    {
        if (showLabel)
        {
            GUI.contentColor = Color.black;
            GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 400, 100), "Hier ist leider nichts!", "color");
        }
        else
        {
            GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 200, 20), "");
        }

    }

    void OnMouseDown()
    {
        Invoke("ToggleLabel", 1);
        Invoke("ToggleLabel", 5);
    }
}
