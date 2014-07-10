using UnityEngine;
using System.Collections;

public class GUInt : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        GUI.Box(new Rect(10, 10, 100, 90), "TEST");
    }
}
