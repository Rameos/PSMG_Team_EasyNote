using UnityEngine;
using System.Collections;

public class Schub1 : MonoBehaviour
{
    bool isClosed;

    public bool isKey = false;
    // Use this for initialization
    void Start()
    {
        isClosed = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isKey)
        {

            if (isClosed)
            {

                animation["schub1"].speed = 1;
                animation.Play("schub1");
                isClosed = false;

            }
            else
            {
                animation["schub1"].speed = -1;
                animation["schub1"].time = animation["schub1"].length;
                animation.Play("schub1");
                isClosed = true;
            }

        }

        else
        {
            audio.Play();
        }

        isKey = false;
    }

    void OnMouseDown()
    {

    }
}
