using UnityEngine;
using System.Collections;

public class HammerClicked : MonoBehaviour {

    private Vector3 startPos;
    private Vector3 screenPoint;
    private Vector3 offset;
    //public float Rotation;
    GameObject weck;
    Wecker wecker;

    private float speed = 30;
    private float moveSpeed = 5;

    

	// Use this for initialization
	void Start () {
        startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        float translation = Input.GetAxis("Mouse ScrollWheel");

        weck = GameObject.FindGameObjectWithTag("wecker");
        wecker = weck.GetComponent<Wecker>(); 
        
	}

    void OnMouseDown()
    {
       
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        
    }

    void OnMouseDrag()
    {
       
        if (Input.mousePosition.x > 40 && Input.mousePosition.x < Screen.width && Input.mousePosition.y > 20 && Input.mousePosition.y < Screen.height)
        {
          
            Vector3 posMouse = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 3f);
            posMouse = Camera.main.ScreenToWorldPoint(posMouse);
            transform.position = posMouse;
            transform.position = new Vector3(transform.position.x, transform.position.y, startPos.z + 0.8f);

        }
        else
        {
            rigidbody.isKinematic = true;
        }

    }

    //Boolean wird auf true gesetzt, sobald die beiden Collider von Hammer und Wecker aufeinander treffen.
    void OnTriggerEnter(Collider other)
    {

        
            if (other.tag == "ziffernblatt" && gameObject.tag == "hammer")
            {
                wecker.destroyed = true;
                
                
            }
    }
        

       

    
}

