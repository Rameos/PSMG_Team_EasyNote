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

        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;

    }

    void OnTriggerEnter(Collider other)
    {
        audio.Play();
        scherben.renderer.enabled = true;
        hammer.renderer.enabled = false;
        hammer.collider.enabled = false;

        ziel.SetActive(false);


    }



    void OnTriggerExit(Collider other)
    {

    }


}