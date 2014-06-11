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
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Debug.Log("Pressed left click.");
        if (Input.GetMouseButtonDown(1))
            Debug.Log("Pressed right click.");
        if (Input.GetMouseButtonDown(2))
            Debug.Log("Pressed middle click.");

        float translation = Input.GetAxis("Mouse ScrollWheel");
        Debug.Log(translation);


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
            //while (gameObject.transform.position.x < 6.5 && gameObject.transform.position.y < 6.5 && gameObject.transform.position.z < 6.5)
            //{ 
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
          

            Vector3 curPosition = Camera1.ScreenToWorldPoint(curScreenPoint) + offset;
            transform.position = curPosition;
       // }
            //gameObject.transform.Rotate(Vector3.up * speed * Input.GetAxis("Mouse ScrollWheel"));

            if (Input.GetAxis("Mouse ScrollWheel") != 0)
            {
                gameObject.transform.Rotate(1, 0, 0);
            }
           
           
        }
	
}
