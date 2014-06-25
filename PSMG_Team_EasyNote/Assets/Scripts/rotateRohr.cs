using UnityEngine;
using System.Collections;

public class rotateRohr : MonoBehaviour {

    GameObject sRohr;


	// Use this for initialization
	void Start () {
        sRohr = GameObject.FindGameObjectWithTag("smallRohr");
	}
	
	// Update is called once per frame
	void Update () {
        // Slowly rotate the object around its X axis at 1 degree/second.
        //gameObject.transform.Rotate(2*Time.deltaTime,0,0);
        // ... at the same time as spinning relative to the global 
        // Y axis at the same speed.
        //gameObject.transform.Rotate(Vector3.up * Time.deltaTime, Space.World);
        
	}

    void OnMouseDown()
    {
       
       sRohr.animation.Play("smallRohrAnim");
        
    }

}
