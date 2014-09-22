using UnityEngine;
using System.Collections;

public class HammerZiehen : MonoBehaviour
{


    Vector3 startPos;
    Vector3 screenPoint;
    Vector3 offset;

    GameObject invMan, hammer, ziel, scherben;

    float speed = 30;
    float moveSpeed = 5;

    void Start()
    {
       
        startPos = transform.position;
        invMan = GameObject.FindGameObjectWithTag("inventar");
        hammer = GameObject.FindGameObjectWithTag("hammerDub");
        ziel = GameObject.FindGameObjectWithTag("Vase");
        scherben = GameObject.FindGameObjectWithTag("scherben");


    }


    void Update()
    {



    }

    void OnMouseDown()
    {
       
        InventarGUI gui = invMan.GetComponent<InventarGUI>();
        if (gui.dragHammer)
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

      
        Debug.Log("enter");
        audio.Play();
        scherben.renderer.enabled = true;
        //hammer.SetActive(false);
        hammer.renderer.enabled = false;
        hammer.collider.enabled = false;
       
        ziel.SetActive(false);
       

    }

    //void OnTriggerStay(Collider other)
    //{
    //    //schrank = GameObject.FindGameObjectWithTag("Schrank");
    //    ///HebelRaetsel hebRaet = Camera.main.GetComponent<HebelRaetsel>();
    //    Debug.Log("stay");
    //    //Debug.Log(hebRaet.visible);
    //    hammer.SetActive(false);
    //    scherben.renderer.enabled = true;

    //    //renderer.enabled = false;
       
    //    ziel.SetActive(false);
    //    //ziel.collider.enabled = false;




    //}


    void OnTriggerExit(Collider other)
    {

    }


}