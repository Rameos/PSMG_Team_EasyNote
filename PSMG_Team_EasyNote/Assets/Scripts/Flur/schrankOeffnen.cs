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
            Debug.Log("OnMouseDown");
            schrank = GameObject.FindGameObjectWithTag("Schrank");
            Debug.Log("Play");
            Debug.Log(schrank.animation.Play("openDoors"));
            schrank.animation.Play("openDoors");
            schrankOffen = true;
            Destroy(schrank.collider);
        }

    }
    


}