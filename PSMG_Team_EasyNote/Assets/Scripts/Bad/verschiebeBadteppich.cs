using UnityEngine;
using System.Collections;

public class verschiebeBadteppich : MonoBehaviour {

    //// Use this for initialization
    //void Start () {
	
    //}
	
    //// Update is called once per frame
    //void Update () {
	
    //}
    void OnMouseDown()
    {
        transform.Translate(Vector3.right * 3);
    }
}
