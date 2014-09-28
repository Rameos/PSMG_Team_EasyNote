using UnityEngine;
using System.Collections;

using UnityEngine;
using System.Collections;
using iViewX;

public class ModiLampe : MonoBehaviourWithGazeComponent
{


    private Vector3 startPos;
    GameObject lamp;

    // Use this for initialization
    void Start()
    {
        lamp = GameObject.FindGameObjectWithTag("lampe");
        gazeUI.Add(new GazeButton(new Rect(), "Cube"));


    }


    private ArrayList gazeUI = new ArrayList();

    void Update()
    {
        MovementCamera movCam = Camera.main.GetComponent<MovementCamera>();
        if (isDrawing)
        {
            foreach (GazeButton button in gazeUI)
            {
                button.Update();
            }
        }



        Vector2 gazePos = (gazeModel.posGazeLeft + gazeModel.posGazeRight) * 0.5f;
        gazePos.y = Screen.height - gazePos.y;





        lamp.light.intensity = 0;
        light.intensity = 1;

        if (movCam.camPos == "TV" || movCam.camPos == "Kommode" || movCam.camPos == "Couch")
        {

            Vector3 posUserGaze = new Vector3(gazePos.x, gazePos.y, 3);
            posUserGaze = Camera.main.ScreenToWorldPoint(posUserGaze);

            transform.position = posUserGaze;
            transform.position = new Vector3(transform.position.x, transform.position.y, startPos.z);
        }

        if (movCam.camPos == "Wand")
        {

            Vector3 posUserGaze = new Vector3(gazePos.x, gazePos.y, 3);
            posUserGaze = Camera.main.ScreenToWorldPoint(posUserGaze);

            transform.position = posUserGaze;
            transform.position = new Vector3(transform.position.x, transform.position.y, 1.81809f);
        }


        if (movCam.camPos == "Regal" || movCam.camPos == "Start")
        {

            lamp.light.intensity = 0;
            light.intensity = 1;

            Vector3 posUserGaze = new Vector3(gazePos.x, gazePos.y, 3);
            posUserGaze = Camera.main.ScreenToWorldPoint(posUserGaze);

            transform.position = posUserGaze;
            transform.position = new Vector3(startPos.x, transform.position.y, transform.position.z);
        }

    }






    void OnGUI()
    {
        if (isDrawing)
        {
            foreach (GazeButton button in gazeUI)
            {
                button.OnGUI();
            }
        }
    }

    public override void OnGazeStay(RaycastHit hit)
    {


    }

    public bool isDrawing { get; set; }

    public override void OnGazeEnter(RaycastHit hit)
    {

    }

    public override void OnGazeExit()
    {

    }

}