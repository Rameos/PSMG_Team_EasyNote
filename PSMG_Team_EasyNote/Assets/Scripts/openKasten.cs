using UnityEngine;
using System.Collections;

public class openKasten : MonoBehaviour
{
    GameObject door;
    // Use this for initialization
    public void OnMouseDown()
    {
        door = GameObject.FindGameObjectWithTag("kasten");
        door.animation.Play("kasten");
        Debug.Log("kasten geklickt");
    }
}
