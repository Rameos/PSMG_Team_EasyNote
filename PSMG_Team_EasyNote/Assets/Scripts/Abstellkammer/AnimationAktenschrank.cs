using UnityEngine;
using System.Collections;

public class AnimationAktenschrank : MonoBehaviour {

    bool AktenschrankMoved = false;

    void OnMouseDown()
    {
        if (AktenschrankMoved == false)
        {
            Debug.Log("OnMouseDown");

            Debug.Log("Play");
            animation.Play("AktenschrankAuf");
            AktenschrankMoved = true;
        }

    }
}
