using UnityEngine;
using System.Collections;

public class MovingCamera : MonoBehaviour
{


    private bool backButtonShow = false;
    GameObject schrank, korb;

    public string cameraPos = "";

    //public float q1 = 0;
    //public float q2 = 0;
    //public float q3 = 0;
    //public float q4 = 0;

    //public float v1 = -1.347125f;
    //public float v2 = 1.245951f;
    //public float v3 = 0.5974661f;



    //ursprünglich
    //-1.347125  1.245951  0.5974661    8.598767   75.93419   0.1737647



    // Use this for initialization
    void Start()
    {
        //Startposition
        setToStartPos();
        schrank = GameObject.FindGameObjectWithTag("Schrank");
        korb = GameObject.FindGameObjectWithTag("hundekorb");

    }

    // Update is called once per frame
    void Update()
    {

        //  transform.position = new Vector3(v1, v2, v3); // Richtet Kamera an gewünschter Position aus
        //transform.rotation = new Quaternion(q1, q2, q3, q4);


        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 50))
            {

                if (hit.transform.gameObject.tag == "hundekorb")
                {

                    transform.position = new Vector3(0.4670035f, 0.4893888f, 1.138688f); // Richtet Kamera an gewünschter Position aus
                    transform.rotation = new Quaternion(4.3f, 10.43f, 0, 69.37f);
                    schrank.collider.enabled = false;
                    backButtonShow = true;
                    korb.collider.enabled = false;
                    cameraPos = "Korb";
                }


                if (hit.transform.gameObject.tag == "schlüsselbrett")
                {

                    transform.position = new Vector3(2.179206f, 1.19675f, 0.59f);
                    transform.rotation = new Quaternion(0, 60, 0, 0);
                    backButtonShow = true;
                    cameraPos = "Brett";
                }



                if (hit.transform.gameObject.tag == "schuhe")
                {

                    transform.position = new Vector3(0.7648869f, 1.211256f, 1.81809f);
                    transform.rotation = new Quaternion(0, 20, -2.43f, 1.78f);
                    backButtonShow = true;
                    cameraPos = "Wand";
                }



                if (hit.transform.gameObject.tag == "Schrank")
                {
                    transform.position = new Vector3(2.179206f, 1.08f, 0.17f);
                    transform.rotation = new Quaternion(14.25f, -4.13f, -0.3f, 292.22f);
                    backButtonShow = true;
                    schrank.collider.enabled = false;
                    cameraPos = "Schrank";

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
                schrank.collider.enabled = true;
                korb.collider.enabled = true;

            }

        }

    }

    private void setToStartPos()
    {
        transform.position = new Vector3(-1.28f, 1.24f, 0.69f);
        transform.rotation = new Quaternion(17.4f, 94.6f, -13.74f, 126f);
        cameraPos = "Start";
        //schrank.collider.enabled = true;
    }
}