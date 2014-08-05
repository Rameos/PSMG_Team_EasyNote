using UnityEngine;
using System.Collections;

public class TriggerAussen : MonoBehaviour {

    public bool RAinRightPos = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
       // RAinRightPos = true;
        RAinRightPos = false;
     
    }

    void OnTriggerStay(Collider other)
    {
        RAinRightPos = true;

    }


    void OnTriggerExit(Collider other)
    {
        RAinRightPos = false;
        //Debug.Log("ist in collider");
    }
}
