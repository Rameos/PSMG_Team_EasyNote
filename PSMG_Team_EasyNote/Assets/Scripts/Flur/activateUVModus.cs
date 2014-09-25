using UnityEngine;
using System.Collections;

public class activateUVModus : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	

    void Update()
    {
        if (Input.GetKey("u"))
        {
            Application.LoadLevel(11);
        }
    }
}
