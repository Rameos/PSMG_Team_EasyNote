using UnityEngine;
using System.Collections;

public class guiTextKiZ : MonoBehaviour {

    string taskText;
    public GUISkin GUISkin;

    void Start()
    {
        
    }

    void Update()
    {

    }

    void OnGUI()
    {
        GUI.Button(new Rect(Screen.width * 0.03f, Screen.height * 0.08f, Screen.width * 0.2f, Screen.height * 0.1f), "Finde die 5 gesuchten Gegenstände");
        GUI.Button(new Rect(Screen.width * 0.8f, Screen.height * 0.08f, Screen.width * 0.2f, Screen.height * 0.1f), "Rubik's Cube");
        GUI.Button(new Rect(Screen.width * 0.8f, Screen.height * 0.20f, Screen.width * 0.2f, Screen.height * 0.1f), "Dokumentstapel");
        GUI.Button(new Rect(Screen.width * 0.8f, Screen.height * 0.30f, Screen.width * 0.2f, Screen.height * 0.1f), "Türkiser Stift");
        GUI.Button(new Rect(Screen.width * 0.8f, Screen.height * 0.40f, Screen.width * 0.2f, Screen.height * 0.1f), "Gelbes Auto");
    }
}
