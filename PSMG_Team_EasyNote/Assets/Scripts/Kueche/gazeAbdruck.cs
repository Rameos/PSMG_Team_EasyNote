using UnityEngine;
using System.Collections;
using iViewX;

public class gazeAbdruck : MonoBehaviourWithGazeComponent
{

    // Use this for initialization
    void Start () {
        gazeUI.Add(new GazeButton(new Rect(),
    "Rotate Cube"));
    }

    // Update is called once per frame
    void Update () {
        if (isDrawing)
        {
            foreach (GazeButton button in gazeUI)
            {
                button.Update();
            }
        }
    }

    private ArrayList gazeUI = new ArrayList();



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

        Color greenColour = new Color(0, 102, 0);

        renderer.material.color = greenColour;
        //if(Input.GetKeyDown(KeyCode.Space))
        //{
        //    //float r = Random.Range(0f,1f);
        //    //float g = Random.Range(0f,1f);
        //    //float b = Random.Range(0f,1f);
        //    Color greenColour = new Color(0, 102, 0);

        //    renderer.material.color = greenColour;
        //}
        
    }


    public bool isDrawing { get; set; }

    public override void OnGazeEnter(RaycastHit hit)
    {

    }

    public override void OnGazeExit()
    {
    
    }
}
