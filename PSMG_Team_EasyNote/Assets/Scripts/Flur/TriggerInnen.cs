using UnityEngine;
using System.Collections;

public class TriggerInnen : MonoBehaviour {


    public bool RIinRightPos = false;

    void Start()
    {

    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
       // RIinRightPos = true;
        RIinRightPos = false;
     
    }

    void OnTriggerStay(Collider other)
    {
        RIinRightPos = true;

    }

    void OnTriggerExit(Collider other)
    {
        RIinRightPos = false;
    
    }
}
