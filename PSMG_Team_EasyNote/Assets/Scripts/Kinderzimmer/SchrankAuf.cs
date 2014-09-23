using UnityEngine;
using System.Collections;

public class SchrankAuf : MonoBehaviour {


    bool schrankMoved = false;

    void OnMouseDown()
    {
        if (schrankMoved == false)
        {
            Debug.Log("OnMouseDown");

            Debug.Log("Play");
            animation.Play("Schrank");
            schrankMoved = true;
        }

    }

}
