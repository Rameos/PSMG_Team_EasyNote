using UnityEngine;
using System.Collections;

public class MovementCamera : MonoBehaviour
{

    private bool backButtonShow = false;




    public string cameraPos = "";







    // Use this for initialization
    void Start()
    {

        setToStartPos();
        //schrank = GameObject.FindGameObjectWithTag("Schrank");

    }

    // Update is called once per frame
    void Update()
    {



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
                    cameraPos = "Regal";
                }


                if (hit.transform.gameObject.tag == "TV") //fernseher weiter weg
                {
                    transform.position = new Vector3(-0.19f, 0.55f, 10.38f);
                    transform.localEulerAngles = new Vector3(0, 0, 0);
                    backButtonShow = true;
                    cameraPos = "TV";
                }



                if (hit.transform.gameObject.tag == "Kommode") //fernseher oben mit schubladen
                {

                    transform.position = new Vector3(-0.19f, 2.46f, 11.43f);
                    transform.localEulerAngles = new Vector3(40.65f, 0f, 0f);
                    backButtonShow = true;
                    cameraPos = "Kommode";
                }



                if (hit.transform.gameObject.tag == "steckerleiste") //steckerleiste
                {
                    transform.position = new Vector3(1.56f, 1.77f, 13.43f);
                    transform.localEulerAngles = new Vector3(40.65f, -59.4f, 0f);
                    backButtonShow = true;
                    cameraPos = "Leiste";

                }


                if (hit.transform.gameObject.tag == "couch")//wand mit bild ??
                {
                    transform.position = new Vector3(-0.26f, 1.72f, 10f);
                    transform.localEulerAngles = new Vector3(6f, -181.8f, 0f);
                    backButtonShow = true;
                    cameraPos = "Wand";
                }

           


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
     

        transform.position = new Vector3(-5.3f, 3.3f, 12.45f);
        transform.localEulerAngles = new Vector3(20.6f, 116.4f, -0.27f);
        cameraPos = "Start";
    }

}