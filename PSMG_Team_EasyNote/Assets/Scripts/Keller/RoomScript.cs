using UnityEngine;
using System.Collections;

public class RoomScript : MonoBehaviour {


    bool KleinesRohr = false;
    bool GroßesRohr = false;

	// Use this for initialization
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("ENTERED");
    }
}
