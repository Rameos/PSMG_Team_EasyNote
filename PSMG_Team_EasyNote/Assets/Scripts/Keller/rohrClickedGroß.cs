using UnityEngine;
using System.Collections;

public class rohrClickedGroß : MonoBehaviour {


    private Vector3 startPos;
    private Vector3 screenPoint;
    private Vector3 offset;
    public float Rotation;

    private float speed = 30;
    private float moveSpeed = 5;

    void Start()
    {
        startPos = transform.position;
    }


    void Update()
    {
        /*if (Input.GetMouseButtonDown(0))
            Debug.Log("Pressed left click.");
        if (Input.GetMouseButtonDown(1))
            Debug.Log("Pressed right click.");
        if (Input.GetMouseButtonDown(2))
            Debug.Log("Pressed middle click.");*/

        float translation = Input.GetAxis("Mouse ScrollWheel");

    }

    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    void OnMouseDrag()
    {
        //if (transform.position.z < 2.7 && transform.position.z > -2.8 && transform.position.y < 2.8 && transform.position.y > 0.0) { 
        if (Input.mousePosition.x > 180 && Input.mousePosition.x < 725 && Input.mousePosition.y > 60 && Input.mousePosition.y < 325)
        {
        Vector3 posMouse = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 3);
        posMouse = Camera.main.ScreenToWorldPoint(posMouse);
        Debug.Log(Input.mousePosition.y);
        transform.position = posMouse;
        transform.position = new Vector3(startPos.x, transform.position.y, transform.position.z);


        if (Input.GetAxis("Mouse ScrollWheel") >= 0)
        {
            gameObject.transform.Rotate(30, 0, 0);
        }
        if (Input.GetAxis("Mouse ScrollWheel") <= 0)
        {
            gameObject.transform.Rotate(-30, 0, 0);
        }

        
        Rotation = transform.rotation.eulerAngles.x;
        
    }
        else
        {
            
        }
       
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("ENTERED BOX");
        if ((Rotation >= 0 && Rotation <= 1))
        {
            Debug.Log("Objekt an richtiger stelle");
         
        }

    }

    void OnSphereCollisionEnter(Collision collision)
    {
        Debug.Log("ENTERED SPHERE");
    }

}