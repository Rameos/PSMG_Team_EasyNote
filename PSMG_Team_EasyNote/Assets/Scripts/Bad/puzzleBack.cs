using UnityEngine;
using System.Collections;

public class puzzleBack : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		OnGUI ();
	}
	void OnGUI(){
		if(GUI.Button(new Rect(20,40,80,20), "Zurück")) {
			Application.LoadLevel(2);
		}
	}
}
