using UnityEngine;
using System.Collections;

public class Quitschen : MonoBehaviour
{

    GameObject spielzeug;
    // Use this for initialization
    void Start()
    {

        spielzeug = GameObject.FindGameObjectWithTag("SpielHund");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {

        spielzeug.audio.Play();
    }
}
