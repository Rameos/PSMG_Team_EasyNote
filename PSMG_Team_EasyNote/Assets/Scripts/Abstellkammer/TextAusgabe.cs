using UnityEngine;
using System.Collections;

public class TextAusgabe : MonoBehaviour {

    string aufgabeAK = "Die Tür bietet keinen Ausweg. Du musst einen anderen Weg heraus suchen!";


    void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 100, 0, 500, 100), aufgabeAK);

    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
