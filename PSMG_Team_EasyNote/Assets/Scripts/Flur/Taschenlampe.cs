using UnityEngine;
using System.Collections;

using UnityEngine;
using System.Collections;
using iViewX;

public class Taschenlampe : MonoBehaviourWithGazeComponent
{

    private bool flashlightOn = false;
    private Vector3 startPos;

    // Use this for initialization
    void Start()
    {

      gazeUI.Add(new GazeButton(new Rect(),
    "Cube"));
    }




    void Update()
    {

       // Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
       // vector3 pos  = ray.GetPoint(5);

        //Vector3 posMouse = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 3);
        //posMouse = Camera.main.ScreenToWorldPoint(posMouse);

        //transform.position = posMouse;
        //transform.position = new Vector3(startPos.x, transform.position.y, transform.position.z);
       

            //Checks if the boolean is true or false.
            if (flashlightOn == true)
            {
                light.intensity = 1;//If the boolean is true, then it sets the intensity to what ever you want.
                Vector3 posMouse = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 3);
                posMouse = Camera.main.ScreenToWorldPoint(posMouse);

                transform.position = posMouse;
                transform.position = new Vector3( transform.position.x, transform.position.y, startPos.z);
       
            }
            else
            {
                if (flashlightOn == false)
                {
                    light.intensity = 0;//If the boolean is false, then it sets the intensity to zero.
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

    public bool isDrawing { get; set; }

  public override void OnGazeEnter(RaycastHit hit)
    {

    }

    public override void OnGazeExit()
    {
    
    }

}
