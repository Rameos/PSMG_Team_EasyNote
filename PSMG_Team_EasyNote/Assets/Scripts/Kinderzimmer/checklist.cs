using UnityEngine;
using System.Collections;

public class checklist : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 70, 50, 30), "Liste"))
            Application.LoadLevel(1);

    }
}