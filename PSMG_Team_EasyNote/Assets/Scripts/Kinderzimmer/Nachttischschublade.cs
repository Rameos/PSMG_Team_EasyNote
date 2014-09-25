using UnityEngine;
using System.Collections;

public class Nachttischschublade : MonoBehaviour {

    bool NachttischSchubMoved = false;

    void OnMouseDown()
    {
        if (NachttischSchubMoved == false)
        {
            Debug.Log("OnMouseDown");

            Debug.Log("Play");
            animation.Play("NachttischschubAuf");
            NachttischSchubMoved = true;
        }
       
    }
}
