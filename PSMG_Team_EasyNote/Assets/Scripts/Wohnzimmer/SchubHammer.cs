using UnityEngine;
using System.Collections;

public class SchubHammer : MonoBehaviour
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

            animation["SchubHammer"].speed = 1;
            animation.Play("SchubHammer");
            isClosed = false;

        }
        else
        {
            animation["SchubHammer"].speed = -1;
            animation["SchubHammer"].time = animation["SchubHammer"].length;
            animation.Play("SchubHammer");
            isClosed = true;
        }

    }
}
