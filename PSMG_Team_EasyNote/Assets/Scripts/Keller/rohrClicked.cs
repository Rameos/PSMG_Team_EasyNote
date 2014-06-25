using UnityEngine;
using System.Collections;

public class rohrClicked : MonoBehaviour {
	
	    /*void OnMouseDown()
        {
            Debug.Log("Rohr clicked");
        }*/
    private Vector3 screenPoint;
    private Vector3 offset;
    private float speed = 30;
    private float moveSpeed = 5;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Debug.Log("Pressed left click.");
        if (Input.GetMouseButtonDown(1))
            Debug.Log("Pressed right click.");
        if (Input.GetMouseButtonDown(2))
            Debug.Log("Pressed middle click.");

        float translation = Input.GetAxis("Mouse ScrollWheel");

 

    

    }
        
        void OnMouseDown()
        {

            screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);

            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
            
           
    }
	
        
        


        void OnMouseDrag()
        {
            Camera Camera1 = GameObject.Find("Camera1").GetComponent<Camera>() as Camera;
            screenPoint = Camera1.WorldToScreenPoint(gameObject.transform.position);
            Debug.Log("!!!!!!!!: " + Input.mousePosition.x);

            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
          

            Vector3 curPosition = Camera1.ScreenToWorldPoint(curScreenPoint) + offset;
            transform.position = curPosition;
            //transform.position.x += moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime; 
            
 
            

            if (Input.GetAxis("Mouse ScrollWheel") >= 0)
            {
                gameObject.transform.Rotate(1, 0, 0);
            }
            if (Input.GetAxis("Mouse ScrollWheel") <= 0)
            {
                gameObject.transform.Rotate(-1, 0, 0);
            }
           
           
        }
	
}
