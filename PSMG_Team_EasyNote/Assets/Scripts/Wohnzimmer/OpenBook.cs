using UnityEngine;
using System.Collections;

public class OpenBook : MonoBehaviour
{


    GameObject remote, book;
    // Use this for initialization
    void Start()
    {

        remote = GameObject.FindGameObjectWithTag("fernDub");

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        FernbedienungZiehen fernScript = remote.GetComponent<FernbedienungZiehen>();
        if (fernScript.showPyr == true)
        {
            audio.Play();
            renderer.enabled = true;
        }


    }
}
