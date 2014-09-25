using UnityEngine;
using System.Collections;

public class MoveCameraKiZ : MonoBehaviour {

    private bool backButtonKiZShow = false;
    public string camPos = "";




    // Use this for initialization
    void Start()
    {

        setToStartPosKiZ();

    }

    void Update()
    {


        

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 50))
            {

                if (hit.transform.gameObject.tag == "Schrankmittel")
                {
                    transform.position = new Vector3(-2.05f, 3.3f, 0.92f);
                    transform.localEulerAngles = new Vector3(43.5f, 266.4f, 354.7f);
                    backButtonKiZShow = true;
                    camPos = "Schrankmittel";
                }


                if (hit.transform.gameObject.tag == "Nachttischschrank")
                {
                    transform.position = new Vector3(-0.15f, 2.8f, -2.3f);
                    transform.localEulerAngles = new Vector3(33.8f, 202.1f, 361.7f);
                    backButtonKiZShow = true;
                    camPos = "Nachttischschrank";
                }

                if (hit.transform.gameObject.tag == "Schrankgroß") 
                {
                    transform.position = new Vector3(-1.3f, 3.3f, 1.7f);
                    transform.localEulerAngles = new Vector3(28.1f, 144.9f, 361.6f);
                    backButtonKiZShow = true;
                    camPos = "Schrankgroß";
                }

            }
        }

    }




    void OnGUI()
    {

        if (backButtonKiZShow)
        {
            if (GUI.Button(new Rect(20, 40, 80, 20), "Zurück"))
            {
                backButtonKiZShow = false;
                setToStartPosKiZ();
            }

        }

    }

    private void setToStartPosKiZ()
    {
        
        transform.position = new Vector3(0.5f, 3.2f, 3.1f);
        transform.localEulerAngles = new Vector3(19.1f, 199.3f, 355.6f);
        camPos = "Start";
    }
}
