using UnityEngine;
using System.Collections;

public class RoentgUVAnfang : MonoBehaviour {

    string aufgabe = "Im Röntgen- oder UV-Modus können keine Gegenstände eingesammelt werden!";

	// Use this for initialization
	void Start () {
	
	}

    void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 100, 0, 500, 100), aufgabe);

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
