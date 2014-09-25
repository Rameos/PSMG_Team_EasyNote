using UnityEngine;
using System.Collections;

public class TeppichWeg : MonoBehaviour {

    bool TeppichMoved = false;

    void OnMouseDown()
    {
        if (TeppichMoved == false)
        {
            Debug.Log("OnMouseDown");

            Debug.Log("Play");
            animation.Play("MoveTeppich");
            TeppichMoved = true;
        }

    }

	
}
