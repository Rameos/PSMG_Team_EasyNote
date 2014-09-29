using UnityEngine;
using System.Collections;

using UnityEngine;
using System.Collections;
using iViewX;

public class TaschenlampeSchlaf : MonoBehaviourWithGazeComponent
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
        if (isDrawing)
        {
            foreach (GazeButton button in gazeUI)
            {
                button.Update();
            }
        }



        Vector2 gazePos = (gazeModel.posGazeLeft + gazeModel.posGazeRight) * 0.5f;
        gazePos.y = Screen.height - gazePos.y;
        //raygaze = Camera.main.ScreenPointToRay(gazePos);




        // Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        // vector3 pos  = ray.GetPoint(5);

        //Vector3 posMouse = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 3);
        //posMouse = Camera.main.ScreenToWorldPoint(posMouse);

        //transform.position = posMouse;
        //transform.position = new Vector3(startPos.x, transform.position.y, transform.position.z);


        //Checks if the boolean is true or false.
        if (flashlightOn == true)
        {


            lamp.light.intensity = 1;
            //light.intensity = 1;//If the boolean is true, then it sets the intensity to what ever you want.
            //Vector3 posMouse = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 3);
            Vector3 posUserGaze = new Vector3(gazePos.x, gazePos.y, 3);
            posUserGaze = Camera.main.ScreenToWorldPoint(posUserGaze);

            transform.position = posUserGaze;
            transform.position = new Vector3(transform.position.x, transform.position.y, startPos.z);
            //transform.position = new Vector3(startPos.x, transform.position.y, transform.position.z);
            //transform.position = new Vector3(transform.position.x, startPos.y, transform.position.z);


        }
        else
        {
            if (flashlightOn == false)
            {
                lamp.light.intensity = 0;
                //light.intensity = 0;
                //If the boolean is false, then it sets the intensity to zero.
            }
        }



        //Checks if the F key is down and whether the boolean is on or off.
        if (Input.GetKeyDown(KeyCode.F) && flashlightOn == false)
        {
            flashlightOn = true;

            Debug.Log("an");//If the f key is down and the boolean is false, it sets the boolean to true.
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.F) && flashlightOn == true)
            {
                flashlightOn = false;//If the f key is down and the boolean is true, it sets the boolean to false.
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