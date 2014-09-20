using UnityEngine;
using System.Collections;

public class MovementCamera : MonoBehaviour
{

    private bool backButtonShow = false;


    //public float q4 = 0;
    public float q1 = 0;
    public float q2 = 0;
    public float q3 = 0;

    public float v1 = 0;
    public float v2 = 0;
    public float v3 = 0;



    public string camPos = "";




    // Use this for initialization
    void Start()
    {

        setToStartPos();
        //schrank = GameObject.FindGameObjectWithTag("Schrank");

    }

    // Update is called once per frame
    void Update()
    {


        //  transform.position = new Vector3(v1, v2, v3);
        // transform.localEulerAngles = new Vector3(q1, q2, q3);

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 50))
            {

                if (hit.transform.gameObject.tag == "Regal")
                {
                    transform.position = new Vector3(-0.73f, 1.57f, 9.4f);
                    transform.localEulerAngles = new Vector3(0f, 90f, 0f);
                    backButtonShow = true;
                    camPos = "Regal";
                }


                if (hit.transform.gameObject.tag == "TV") //fernseher weiter weg
                {
                    transform.position = new Vector3(-0.19f, 0.55f, 10.38f);
                    transform.localEulerAngles = new Vector3(0, 0, 0);
                    backButtonShow = true;
                    camPos = "TV";
                }



                if (hit.transform.gameObject.tag == "Kommode") //fernseher oben mit schubladen
                {

                    transform.position = new Vector3(-0.19f, 2.46f, 11.43f);
                    transform.localEulerAngles = new Vector3(40.65f, 0f, 0f);
                    backButtonShow = true;
                    camPos = "Kommode";
                }



                if (hit.transform.gameObject.tag == "steckerleiste") //steckerleiste
                {
                    transform.position = new Vector3(1.56f, 1.77f, 13.43f);
                    transform.localEulerAngles = new Vector3(40.65f, -59.4f, 0f);
                    backButtonShow = true;
                    camPos = "Leiste";

                }


                if (hit.transform.gameObject.tag == "couch")//wand mit bild ??
                {
                    transform.position = new Vector3(-0.26f, 1.72f, 10f);
                    transform.localEulerAngles = new Vector3(6f, -181.8f, 0f);
                    backButtonShow = true;
                    camPos = "Wand";
                }

                //if (hit.transform.gameObject.tag == "Bild") //safe
                //{

                //    transform.position = new Vector3(0.91f, 2.89f, 6.2f);
                //    transform.localEulerAngles = new Vector3(6f, -181.8f, 0f);
                //    backButtonShow = true;
                //}


            }
        }

    }




    void OnGUI()
    {

        if (backButtonShow)
        {
            if (GUI.Button(new Rect(20, 40, 80, 20), "Zurück"))
            {
                backButtonShow = false;
                setToStartPos();
            }

        }

    }

    private void setToStartPos()
    {
        //transform.position = new Vector3(15.83f, 120.6f, 0.0f);

        //transform.localEulerAngles = new Vector3(-5.36f, 2.91f, 0.0f);

        transform.position = new Vector3(-5.3f, 3.3f, 12.45f);
        transform.localEulerAngles = new Vector3(20.6f, 116.4f, -0.27f);
        camPos = "Start";
    }

}