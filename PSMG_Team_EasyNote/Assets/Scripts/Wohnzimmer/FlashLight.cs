using UnityEngine;
using System.Collections;

using UnityEngine;
using System.Collections;
using iViewX;

public class FlashLight : MonoBehaviourWithGazeComponent
{

    private bool flashlightOn = false;
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



        //Checks if the boolean is true or false.
        if (flashlightOn == true)
        {
            lamp.light.intensity = 1;


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
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
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
        else
        {
            if (flashlightOn == false)
            {
                lamp.light.intensity = 1;
                light.intensity = 0;//If the boolean is false, then it sets the intensity to zero.
            }
        }



        //Checks if the F key is down and whether the boolean is on or off.
        if (Input.GetKeyDown(KeyCode.F) && flashlightOn == false)
        {
            flashlightOn = true;

            Debug.Log("Taschenlampe an");//If the f key is down and the boolean is false, it sets the boolean to true.
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.F) && flashlightOn == true)
            {
                flashlightOn = false;//If the f key is down and the boolean is true, it sets the boolean to false.
                Debug.Log("Taschenlampe aus");
            }
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
