using UnityEngine;
using System.Collections;

public class karton : MonoBehaviour
{


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

        float translation = Input.GetAxis("Mouse ScrollWheel");

    }

    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    void OnMouseDrag()
    {
        if (Input.mousePosition.x > 180 && Input.mousePosition.x < 725 && Input.mousePosition.y > 60 && Input.mousePosition.y < 325)
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
            Debug.Log("Y: " + transform.position.y);
            Debug.Log("Z: " + transform.position.z);
        }

    }


}