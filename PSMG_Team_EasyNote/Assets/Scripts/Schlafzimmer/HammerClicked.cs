﻿using UnityEngine;
using System.Collections;

public class HammerClicked : MonoBehaviour {

    private Vector3 startPos;
    private Vector3 screenPoint;
    private Vector3 offset;
    public float Rotation;
    GameObject hammer;

    private float speed = 30;
    private float moveSpeed = 5;

	// Use this for initialization
	void Start () {
        startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        float translation = Input.GetAxis("Mouse ScrollWheel");
	}

    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    void OnMouseDrag()
    {
       
        if (Input.mousePosition.x > 40 && Input.mousePosition.x < 1365 && Input.mousePosition.y > 20 && Input.mousePosition.y < Screen.height)
        {
          
            Vector3 posMouse = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 3f);
            posMouse = Camera.main.ScreenToWorldPoint(posMouse);
            transform.position = posMouse;
            transform.position = new Vector3(transform.position.x, transform.position.y, startPos.z + 0.7f);



            Rotation = transform.rotation.eulerAngles.x;
        }

    }

    void OnTriggerStay(Collider other)
    {

       
            if (other.tag == "wecker" && gameObject.tag == "hammer")
            {
                Debug.Log("KLAPPT!!");
                hammer = GameObject.FindGameObjectWithTag("hammer");
                hammer.animation.Play("hammerAnim");
                
            }
        

       

    }
}