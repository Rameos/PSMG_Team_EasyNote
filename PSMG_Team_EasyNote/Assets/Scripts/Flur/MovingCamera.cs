using UnityEngine;
using System.Collections;

public class MovingCamera : MonoBehaviour
{


    private bool backButtonShow = false;
    GameObject schrank, korb;

    public string cameraPos = "";


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

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 50))
            {

                if (hit.transform.gameObject.tag == "hundekorb")
                {

                    transform.position = new Vector3(0.1704606f, 0.4893888f, 0.2440029f);
                    transform.localEulerAngles = new Vector3(0f, 0f, 0f);
                    schrank.collider.enabled = false;
                    backButtonShow = true;
                    korb.collider.enabled = false;
                    cameraPos = "Korb";
                }


                if (hit.transform.gameObject.tag == "schlüsselbrett")
                {

                    transform.position = new Vector3(2.179206f, 1.19675f, 0.783928f);
                    transform.localEulerAngles = new Vector3(0f, 180f, 0f);
                    backButtonShow = true;
                    cameraPos = "Brett";
                }



                if (hit.transform.gameObject.tag == "schuhe")
                {

                    transform.position = new Vector3(1.406515f, 0.8098764f, 2.068519f);
                    transform.localEulerAngles = new Vector3(0f, 180f, 0f);
                    backButtonShow = true;
                    cameraPos = "Wand";
                }



                if (hit.transform.gameObject.tag == "Schrank")
                {
                    transform.position = new Vector3(2.070689f, 0.8977109f, 0.17f);
                    transform.localEulerAngles = new Vector3(0f, 0f, 0f);
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
        transform.position = new Vector3(-1.705902f, 1.355807f, 1.276451f);
        transform.localEulerAngles = new Vector3(15.21146f, 90f, 0f);
        cameraPos = "Start";

    }
}