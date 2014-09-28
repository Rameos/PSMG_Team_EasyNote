using UnityEngine;
using System.Collections;

public class schrankOeffnen : MonoBehaviour
{
    GameObject schrank;
    bool schrankOffen = false;

    void OnMouseDown()
    {
        if (schrankOffen == false)
        {

            schrank = GameObject.FindGameObjectWithTag("Schrank");
            schrank.animation.Play("openDoors");
            schrank.audio.Play();
            schrankOffen = true;

        }

    }



}