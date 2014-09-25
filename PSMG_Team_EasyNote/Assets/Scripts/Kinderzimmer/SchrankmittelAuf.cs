using UnityEngine;
using System.Collections;

public class SchrankmittelAuf : MonoBehaviour {

    bool SchrankmittelMoved = false;

    void OnMouseDown()
    {
        if (SchrankmittelMoved == false)
        {
            Debug.Log("OnMouseDown");

            Debug.Log("Play");
            animation.Play("Schrankmittel");
            SchrankmittelMoved = true;
        }

    }
}
