using UnityEngine;
using System.Collections;

public class rohrClicked : MonoBehaviour {
	
	    /*void OnMouseDown()
        {
            Debug.Log("Rohr clicked");
        }*/
    private Vector3 screenPoint;
    private Vector3 offset;

        void OnMouseDown()
        {
            screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);

            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        }


        void OnMouseDrag()
        {
            screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
            //while (gameObject.transform.position.x < 6.5 && gameObject.transform.position.y < 6.5 && gameObject.transform.position.z < 6.5)
            //{ 
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
            Debug.Log("MousePositionX: "+Input.mousePosition.x);
            Debug.Log("MousePositionY: " + Input.mousePosition.y);
            Debug.Log("ScreenpointZ: " + screenPoint.z);

            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
            transform.position = curPosition;
       // }
            Debug.Log(screenPoint.x);
            Debug.Log(screenPoint.y);
            Debug.Log(screenPoint.z);
            Debug.Log("gameobject X: " + gameObject.transform.position.x);
            Debug.Log("gameobject Y: " + gameObject.transform.position.y);
            Debug.Log("gameobject Z: " + gameObject.transform.position.z);
        }
	
}
