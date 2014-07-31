using UnityEngine;
using System.Collections;

public class TriggerMitte : MonoBehaviour {


    public bool RMinRightPos = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
       // RMinRightPos = true;
        RMinRightPos = false;

    }


    void OnTriggerStay(Collider other)
    {
        RMinRightPos = true;

    }


    void OnTriggerExit(Collider other)
    {
        RMinRightPos = false;
      
    }
}
