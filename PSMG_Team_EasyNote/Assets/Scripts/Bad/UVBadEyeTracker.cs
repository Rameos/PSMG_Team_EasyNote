using UnityEngine;
using System.Collections;

using UnityEngine;
using System.Collections;
using iViewX;

public class UVBadEyeTracker : MonoBehaviourWithGazeComponent
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
        MovingCamera movCam = Camera.main.GetComponent<MovingCamera>();
        if (isDrawing)
        {
            foreach (GazeButton button in gazeUI)
            {
                button.Update();
            }
        }



        Vector2 gazePos = (gazeModel.posGazeLeft + gazeModel.posGazeRight) * 0.5f;
        gazePos.y = Screen.height - gazePos.y;



        lamp.light.intensity = 1;


            Vector3 posUserGaze = new Vector3(gazePos.x, gazePos.y, 3);
            posUserGaze = Camera.main.ScreenToWorldPoint(posUserGaze);

            transform.position = posUserGaze;
            transform.position = new Vector3(transform.position.x, transform.position.y);
  

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