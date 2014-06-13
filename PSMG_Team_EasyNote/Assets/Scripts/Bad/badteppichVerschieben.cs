using UnityEngine;
using System.Collections;

public class badteppichVerschieben : MonoBehaviour {

    //// Use this for initialization
    //void Start () {
	
    //}
	
    //// Update is called once per frame
    //void Update () {
	
    //}
    GameObject badteppich;
    bool badteppichMoved = false;

    void OnMouseDown()
    {
        if(badteppichMoved==false)
        {
            Debug.Log("OnMouseDown");
            badteppich = GameObject.FindGameObjectWithTag("badteppich");
            Debug.Log("Play");
            badteppich.animation.Play("badteppichVerschieben");
            badteppichMoved = true;
        }
    }
}
