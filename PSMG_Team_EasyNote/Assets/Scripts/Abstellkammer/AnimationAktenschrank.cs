using UnityEngine;
using System.Collections;

public class AnimationAktenschrank : MonoBehaviour {

    bool AktenschrankMoved = false;
    GameObject aktenschrank;

    void OnMouseDown()
    {
        aktenschrank.audio.Play();

        if (AktenschrankMoved == false)
        {
            

            animation.Play("AktenschrankAuf");
            AktenschrankMoved = true;
        }

    }
}
