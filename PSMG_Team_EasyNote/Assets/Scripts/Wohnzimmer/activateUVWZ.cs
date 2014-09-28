using UnityEngine;
using System.Collections;

public class activateUVWZ : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
    void Update()
    {
        if (Input.GetKey("u"))
        {
            Application.LoadLevel(18);
        }
    }
}
