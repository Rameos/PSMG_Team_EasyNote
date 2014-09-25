using UnityEngine;
using System.Collections;

public class MoveCameraAK : MonoBehaviour {

    private bool backButtonAKShow = false;
    public string camPos = "";




    // Use this for initialization
    void Start()
    {

        setToStartPosAK();

    }

    void Update()
    {




        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 50))
            {

                if (hit.transform.gameObject.tag == "Aktenschrank")
                {
                    transform.position = new Vector3(-0.096f, 1.86f, -1.17f);
                    transform.localEulerAngles = new Vector3(19.8f, 284.9f, 5.16f);
                    backButtonAKShow = true;
                    camPos = "Aktenschrank";
                }


                if (hit.transform.gameObject.tag == "RegalAK") 
                {
                    transform.position = new Vector3(0.0019f, 0.0014f, -0.015f);
                    transform.localEulerAngles = new Vector3(90f, 90f, 0f);
                    backButtonAKShow = true;
                    camPos = "RegalAK";
                }


            }
        }

    }

    void OnGUI()
    {

        if (backButtonAKShow)
        {
            if (GUI.Button(new Rect(20, 40, 80, 20), "Zurück"))
            {
                backButtonAKShow = false;
                setToStartPosAK();
            }

        }

    }

    private void setToStartPosAK()
    {

        transform.position = new Vector3(-0.62f, 1f, -3.04f);
        transform.localEulerAngles = new Vector3(0f, 0f, 0f);
        camPos = "Start";
    }
}
