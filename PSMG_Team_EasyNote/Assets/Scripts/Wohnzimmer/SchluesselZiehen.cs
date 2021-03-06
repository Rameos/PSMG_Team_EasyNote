﻿using UnityEngine;
using System.Collections;

public class SchluesselZiehen : MonoBehaviour
{


    Vector3 startPos;
    Vector3 screenPoint;
    Vector3 offset;

    GameObject invMan, schlüssel, ziel;


    void Start()
    {

        startPos = transform.position;
        invMan = GameObject.FindGameObjectWithTag("inventar");
        schlüssel = GameObject.FindGameObjectWithTag("schlüsselDub");
        ziel = GameObject.FindGameObjectWithTag("schub1");



    }


    void Update()
    {



    }

    void OnMouseDown()
    {

        InventarGUI gui = invMan.GetComponent<InventarGUI>();

        if (gui.dragSchlüssel)
        {
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

        Schub1 schubÖffnen = ziel.GetComponent<Schub1>();
        schubÖffnen.isKey = true;
        schlüssel.SetActive(false);



    }


    void OnTriggerExit(Collider other)
    {

    }


}