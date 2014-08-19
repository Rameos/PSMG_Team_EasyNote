using UnityEngine;
using System.Collections;

public class Wecker : MonoBehaviour {

    GameObject wecker;
	// Use this for initialization
	void Start () {
        wecker = GameObject.FindGameObjectWithTag("wecker");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        wecker.audio.Play();
    }
}
