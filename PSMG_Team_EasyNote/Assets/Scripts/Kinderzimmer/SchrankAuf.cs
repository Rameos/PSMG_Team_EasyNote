using UnityEngine;
using System.Collections;

public class SchrankAuf : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void onMouseDown()
    {
        animation.Play("Schrank");
    }
}
