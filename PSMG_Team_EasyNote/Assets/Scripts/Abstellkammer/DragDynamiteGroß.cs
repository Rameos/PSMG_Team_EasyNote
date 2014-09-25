using UnityEngine;
using System.Collections;

public class DragDynamiteGroß : MonoBehaviour {

    Vector3 startPos;
    Vector3 screenPoint;
    Vector3 offset;

    public float radius = 2.0F;
    public float power = 50.0F;

    GameObject invAK, dynamitgroß, paketgroß;

    float speed = 30;
    float moveSpeed = 5;

    void Start()
    {

        startPos = transform.position;
        invAK = GameObject.FindGameObjectWithTag("inventar");
        dynamitgroß = GameObject.FindGameObjectWithTag("DynamitgroßDub");
        paketgroß = GameObject.FindGameObjectWithTag("Paketgroß");



    }


    void Update()
    {



    }

    void OnMouseDown()
    {

        InvGUI gui = invAK.GetComponent<InvGUI>();
        if (gui.dragDynamitgroß)
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
        //scherben.renderer.enabled = true;
        //hammer.SetActive(false);
        dynamitgroß.renderer.enabled = false;
        dynamitgroß.collider.enabled = false;

        paketgroß.SetActive(false);


    }
    void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "Dynamitgroß" && other.tag == "Paketgroß")
        {
            rigidbody.isKinematic = false;
            rigidbody.useGravity = true;
            explosion();
        }


    }

    void explosion()
    {
        Vector3 explosionPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
        foreach (Collider hit in colliders)
        {
            if (hit && hit.rigidbody)
                hit.rigidbody.AddExplosionForce(power, explosionPos, radius, 3.0F);

        }
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



}
