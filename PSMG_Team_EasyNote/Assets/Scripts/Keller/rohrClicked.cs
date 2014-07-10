using UnityEngine;
using System.Collections;

public class rohrClicked : MonoBehaviour {

    private Vector3 startPos;
    private Vector3 screenPoint;
    private Vector3 offset;
    public float Rotation;
    
    private float speed = 30;
    private float moveSpeed = 5;
    private bool test = true;

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
            while (test == true)
            {

                Vector3 posMouse = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 3);
                posMouse = Camera.main.ScreenToWorldPoint(posMouse);

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
        }

   

    

 
    
    void OnBoxCollisionEnter(Collider other)
    {
        Debug.Log("ENTERED BOX");
        //if ((Rotation >= 0 && Rotation <= 5) || (Rotation >= 355 && Rotation <= 360))
        {
            Debug.Log("Objekt an richtiger stelle");

        }

    }

    void OnSphereCollisionEnter(Collision collision)
    {
        Debug.Log("ENTERED SPHERE");
    }
}
