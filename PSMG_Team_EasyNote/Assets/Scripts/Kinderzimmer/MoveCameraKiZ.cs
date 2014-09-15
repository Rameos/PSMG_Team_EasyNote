using UnityEngine;
using System.Collections;

public class MoveCameraKiZ : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        //setToStartPos();

    }

    // Update is called once per frame
    void Update()
    {
        //(-1.5, 2.4, 0.09)
        if (Input.GetKey("1"))
        {
            transform.position = new Vector3(0, 3, 0); // Richtet Kamera an gewünschter Position aus
            transform.rotation = new Quaternion(0, -25, 5, 8);
        }
        if (Input.GetKey("2"))
        {
            transform.position = new Vector3(-1, 2, -3);
            transform.rotation = new Quaternion(0, -25, 4, 60);
        }
        if (Input.GetKey("3"))
        {
            transform.position = new Vector3(1, 3, 3);
            transform.rotation = new Quaternion(0, 270, -25, 0);
        }
        if (Input.GetKey("4"))
        {
            transform.position = new Vector3(-2, 2, 3);
            transform.rotation = new Quaternion(0, 150, 0, 70);
        }
        
    }
}
