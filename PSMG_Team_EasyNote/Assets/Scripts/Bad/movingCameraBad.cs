using UnityEngine;
using System.Collections;

public class movingCameraBad : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey("1"))
		{
			transform.position = new Vector3(0,3,5); // Richtet Kamera an gewünschter Position aus
			transform.rotation = new Quaternion(0,100,-20,1);
		}
		if (Input.GetKey("2"))
		{
			transform.position = new Vector3(0, 2, 0);
			transform.rotation = new Quaternion(0,150,-31,1);
		}
		if (Input.GetKey("3"))
		{
			transform.position = new Vector3(0, 5, 0);
			transform.rotation = new Quaternion(0, 30,-30,1);
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
