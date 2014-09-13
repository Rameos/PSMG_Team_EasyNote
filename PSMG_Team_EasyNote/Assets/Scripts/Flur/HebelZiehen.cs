using UnityEngine;
using System.Collections;

public class HebelZiehen : MonoBehaviour {


   Vector3 startPos;
   Vector3 screenPoint;
   Vector3 offset;

   GameObject invMan, HLinks, schrank;

  float speed = 30;
    float moveSpeed = 5;

    void Start()
    {
        //renderer.enabled = true;
        startPos = transform.position;
        invMan = GameObject.FindGameObjectWithTag("inventory");
        schrank = GameObject.FindGameObjectWithTag("Schrank");
        

    }


    void Update()
    {

    

    }

    void OnMouseDown()
    {
        InventoryGUI gui = invMan.GetComponent<InventoryGUI>();
        if (gui.dragHebel)
        {

            renderer.enabled = true;
            screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        }
    }

    void OnMouseDrag()
    {
        //if (Input.mousePosition.x > 290 && Input.mousePosition.x < 1200 && Input.mousePosition.y > 120 && Input.mousePosition.y < 550)
        //{
        //    Debug.Log("Gesucht: "+Input.mousePosition.y);
        //    Vector3 posMouse = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 3);
        //    posMouse = Camera.main.ScreenToWorldPoint(posMouse);

        //    transform.position = posMouse;
        //    transform.position = new Vector3(startPos.x, transform.position.y, transform.position.z);


                       
        //}

        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);

        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;

    }

    void OnTriggerEnter(Collider other)
    {
        

    }

    void OnTriggerStay(Collider other)
    {
        HebelRaetsel hebRaet = schrank.GetComponent<HebelRaetsel>();
        Debug.Log("stay");
        renderer.enabled = false;
        hebRaet.visible = true;
        



    }


    void OnTriggerExit(Collider other)
    {
    
    }


}