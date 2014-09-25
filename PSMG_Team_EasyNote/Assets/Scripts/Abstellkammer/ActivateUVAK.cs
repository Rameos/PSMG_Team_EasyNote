using UnityEngine;
using System.Collections;

public class ActivateUVAK : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void Update()
    {
        if (Input.GetKey("u"))
        {
            Application.LoadLevel(23);
        }
    }
}
