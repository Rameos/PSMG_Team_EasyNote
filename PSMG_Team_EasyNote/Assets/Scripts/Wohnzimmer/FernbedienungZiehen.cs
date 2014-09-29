using UnityEngine;
using System.Collections;

public class FernbedienungZiehen : MonoBehaviour
{


    Vector3 startPos;
    Vector3 screenPoint;
    Vector3 offset;

    GameObject invMan, remote, ziel, tv, schalter;
    public Texture tvPyr;

    public bool showPyr = false;

    float speed = 30;
    float moveSpeed = 5;

    void Start()
    {

        startPos = transform.position;
        invMan = GameObject.FindGameObjectWithTag("inventar");
        remote = GameObject.FindGameObjectWithTag("fernDub");
        ziel = GameObject.FindGameObjectWithTag("schub1");
        tv = GameObject.FindGameObjectWithTag("TV");
        schalter = GameObject.FindGameObjectWithTag("schalter");

    }


    void Update()
    {

    }

    void OnMouseDown()
    {

        InventarGUI gui = invMan.GetComponent<InventarGUI>();

        if (gui.dragRemote)
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
        SchalterClicked tvSchalter = schalter.GetComponent<SchalterClicked>();
        if (tvSchalter.schalterAn)
        {
            tv.renderer.material.mainTexture = tvPyr;
            remote.SetActive(false);
            showPyr = true;

        }

        else
        {
            
        }

    }




    void OnTriggerExit(Collider other)
    {

    }


}
