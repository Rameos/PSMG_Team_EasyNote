using UnityEngine;
using System.Collections;

public class movingCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetKey("1"))
        {
            transform.position = new Vector3(-4,3,9); // Richtet Kamera an gewünschter Position aus
            transform.rotation = new Quaternion(0,10,0,1);
        }
        if (Input.GetKey("2"))
        {
            transform.position = new Vector3(-6, 2, 3);
            transform.rotation = new Quaternion(0,170,-51,1);
        }
        if (Input.GetKey("3"))
        {
            transform.position = new Vector3(-6, 2, 3);
            transform.rotation = new Quaternion(0, 170, 1, 51);
        }
        if (Input.GetKey("4"))
        {
            transform.position = new Vector3(-1,1,1);
            transform.rotation = new Quaternion(0,80,0,80);
        }
	}

    //void moveCamera()
    //{
    //    if (Input.GetKey(KeyCode.W))
    //    {
    //        gameObject.transform.position();
    //    }
    //}
}
