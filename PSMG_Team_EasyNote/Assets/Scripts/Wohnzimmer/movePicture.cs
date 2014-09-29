using UnityEngine;
using System.Collections;

public class movePicture : MonoBehaviour
{

    public bool picMoved = false;

    void OnMouseDown()
    {
        if (picMoved == false)
        {
            animation.Play("movePic");
            picMoved = true;
        }

    }



}

