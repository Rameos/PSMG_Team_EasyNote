using UnityEngine;
using System.Collections;

public class Ballerina4 : MonoBehaviour {

    bool BallerinaMoved = false;
    GameObject ballerina;

    void Start()
    {

        ballerina = GameObject.FindGameObjectWithTag("Ballerina");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {


        ballerina.audio.Play();

        if (BallerinaMoved == false)
        {
            
            animation.Play("Ballerina4");
            BallerinaMoved = true;
        }
    }
}
