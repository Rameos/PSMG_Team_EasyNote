using UnityEngine;
using System.Collections;

public class HebelZiehen : MonoBehaviour
{


    Vector3 startPos;
    Vector3 screenPoint;
    Vector3 offset;

    GameObject invMan, hebel, schrank, ziel;

    float speed = 30;
    float moveSpeed = 5;

    void Start()
    {

        startPos = transform.position;
        invMan = GameObject.FindGameObjectWithTag("inventory");
        schrank = GameObject.FindGameObjectWithTag("Schrank");
        hebel = GameObject.FindGameObjectWithTag("hebelDub");
        ziel = GameObject.FindGameObjectWithTag("abdeckung");


    }


    void Update()
    {



    }

    void OnMouseDown()
    {
        Debug.Log("ziehen");
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

        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;

    }

    void OnTriggerEnter(Collider other)
    {


    }

    void OnTriggerStay(Collider other)
    {

        HebelRaetsel hebRaet = Camera.main.GetComponent<HebelRaetsel>();
        hebel.SetActive(false);
        hebRaet.visible = true;
        ziel.collider.enabled = false;




    }


    void OnTriggerExit(Collider other)
    {

    }


}