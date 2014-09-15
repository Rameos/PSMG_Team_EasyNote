using UnityEngine;
using System.Collections;

public class guiTextKiZ : MonoBehaviour {

    string taskText;
    public GUISkin GUISkin;

    void Start()
    {
        
    }

    //void Update()
    //{
      //  OnGUI();
    //}

    void OnGUI()
    {
        GUI.Button(new Rect(Screen.width * 0.03f, Screen.height * 0.08f, Screen.width * 0.2f, Screen.height * 0.1f), "Finde die 5 gesuchten Gegenstände");
    }
}
