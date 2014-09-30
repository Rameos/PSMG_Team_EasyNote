using UnityEngine;
using System.Collections;

public class rohrClickedGroß : MonoBehaviour {


    private Vector3 startPos;
    private Vector3 screenPoint;
    private Vector3 offset;
    public float Rotation;

    private float speed = 30;
    private float moveSpeed = 5;
    GameObject rohrGroß;
    GameObject kasten;
    guiTextKeller guiKeller;
    openKasten openKasten;

    public bool rohrGr = false;

    void Start()
    {
        startPos = transform.position;

        rohrGroß = GameObject.FindGameObjectWithTag("rohrGroß");
        guiKeller = rohrGroß.GetComponent<guiTextKeller>();

        kasten = GameObject.FindGameObjectWithTag("kastenDoor");
        openKasten = kasten.GetComponent<openKasten>();
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

    //Die Kastentüre muss bereits geöffnet sein (bzw. das Licht angeschaltet), um das Rohr draggen und rotieren zu können.
    void OnMouseDrag()
    {
        if (openKasten.lightOn == true)
        {
            if (Input.mousePosition.x > 300 && Input.mousePosition.x < Screen.width - 250 && Input.mousePosition.y > 100 && Input.mousePosition.y < Screen.height)
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

    //Wird das Rohr an die richtige Stelle gesetzt, bekommt der Spieler eine Benachrichtigung und der boolesche Wert wird true.
    void OnTriggerEnter(Collider other)
    {     

        if ((Rotation >= 30 && Rotation <= 31 || Rotation >= 299 && Rotation <= 300))
        {
            if (other.tag == "rohrGroß")
            {
               
                rohrGr = true;
                guiKeller.printHelpText("Du hast das große Rohr richtig angebracht!");
                
            }
        }

    }




}