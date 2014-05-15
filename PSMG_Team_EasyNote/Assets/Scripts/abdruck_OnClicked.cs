using UnityEngine;
using System.Collections;

public class abdruck_OnClicked : MonoBehaviour {

    //// Use this for initialization
    //void Start () {
	
    //}
	
    //// Update is called once per frame
    //void Update () {
	
    //}

    void OnMouseDown(){
        //float r = Random.Range(0f,1f);
        //float g = Random.Range(0f,1f);
        //float b = Random.Range(0f,1f);
        Color greenColour = new Color(0, 102, 0);
        
        renderer.material.color = greenColour;
    }

}
