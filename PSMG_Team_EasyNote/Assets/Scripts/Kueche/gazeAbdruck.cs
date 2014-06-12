using UnityEngine;
using System.Collections;
using iViewX;

public abstract class gazeAbdruck : MonoBehaviourWithGazeComponent
{

    //// Use this for initialization
    //void Start () {

    //}

    //// Update is called once per frame
    //void Update () {

    //}

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

}
