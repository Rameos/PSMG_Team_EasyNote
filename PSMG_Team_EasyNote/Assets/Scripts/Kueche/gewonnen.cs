using UnityEngine;
using System.Collections;

public class gewonnen : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
				if (gewinnAbfrage.katzeStatus == 1) {
			Application.LoadLevel(7);
				}
		}
}
