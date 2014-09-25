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

        Debug.Log("clicked");

        ballerina.audio.Play();

        if (BallerinaMoved == false)
        {
            Debug.Log("OnMouseDown");

            Debug.Log("Play");
            animation.Play("Ballerina4");
            BallerinaMoved = true;
        }
    }
}
