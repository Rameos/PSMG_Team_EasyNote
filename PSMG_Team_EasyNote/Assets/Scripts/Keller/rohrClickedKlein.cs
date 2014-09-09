using UnityEngine;
using System.Collections;

public class rohrClickedKlein : MonoBehaviour
{


    private Vector3 startPos;
    private Vector3 screenPoint;
    private Vector3 offset;
    public float Rotation;

    private float speed = 30;
    private float moveSpeed = 5;

    public bool rohrKl = false;
    GameObject rohrKlein;
    GameObject kasten;
    guiTextKeller guiKeller;
    openKasten openKasten;

    void Start()
    {
        startPos = transform.position;

        rohrKlein = GameObject.FindGameObjectWithTag("rohrKlein");
        guiKeller = rohrKlein.GetComponent<guiTextKeller>();

        kasten = GameObject.FindGameObjectWithTag("kastenDoor");
        openKasten = kasten.GetComponent<openKasten>();
    }


    void Update()
    {
        /*if (Input.GetMouseButtonDown(0))
            Debug.Log("Pressed left click.");
        if (Input.GetMouseButtonDown(1))
            Debug.Log("Pressed right click.");
        if (Input.GetMouseButtonDown(2))
            Debug.Log("Pressed middle click.");*/

        float translation = Input.GetAxis("Mouse ScrollWheel");

    }

    void OnMouseDown()
    {
       
            screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        
    }

    void OnMouseDrag()
    {
        if (openKasten.lightOn == true)
        {
            if (Input.mousePosition.x > 200 && Input.mousePosition.x < Screen.width - 150 && Input.mousePosition.y > 120 && Input.mousePosition.y < Screen.height)
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
            }
            else
            {

            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        
        if ((Rotation >= 0 && Rotation <= 1))
        {
            if (other.tag == "rohrKlein")
            {
                Debug.Log("Kleines Rohr richtig angebracht");
                rohrKl = true;
                Debug.Log("rohrKl " + rohrKl);
                guiKeller.printHelpText("Du hast das kleine Rohr richtig angebracht!");
            }
        }

        /*if ((Rotation >= 30 && Rotation <= 31 || Rotation >= 299 && Rotation <= 300))
        {
            if (other.tag == "rohrGroß")
            {
                Debug.Log("Großes Rohr richtig angebracht");
            }
        }

        if ((Rotation == 90 || Rotation == 270))
        {
            if (other.tag == "kabel" && gameObject.tag == "kabel")
            {
                Debug.Log("Kabel richtig");
            }
        }*/

    }


}