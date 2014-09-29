using UnityEngine;
using System.Collections;

public class schub2 : MonoBehaviour
{


    bool isClosed;
    // Use this for initialization
    void Start()
    {
        isClosed = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        if (isClosed)
        {

            animation["schub2"].speed = 1;
            animation.Play("schub2");
            isClosed = false;

        }
        else
        {
            animation["schub2"].speed = -1;
            animation["schub2"].time = animation["schub2"].length;
            animation.Play("schub2");
            isClosed = true;
        }

    }
}
