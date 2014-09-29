using UnityEngine;
using System.Collections;

public class LeaveRoom : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {

        renderer.enabled = true;
        Application.LoadLevel(2);
    }
}
