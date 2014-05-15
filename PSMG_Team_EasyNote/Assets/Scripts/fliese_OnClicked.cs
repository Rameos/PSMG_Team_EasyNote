using UnityEngine;
using System.Collections;

public class fliese_OnClicked : MonoBehaviour {

    //// Use this for initialization
    //void Start () {
	
    //}
	
    //// Update is called once per frame
    //void Update () {
    //    OnMouseDown();
    //}

    void OnMouseDown()
    {
        transform.Translate(Vector3.right * 1);
        
    }
}
