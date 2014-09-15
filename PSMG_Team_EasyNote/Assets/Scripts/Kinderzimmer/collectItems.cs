using UnityEngine;
using System.Collections;

public class collectItems : MonoBehaviour {

    void update()
    {
        if (Input.GetMouseButtonDown (0)) 
        {
            Destroy(gameObject);
    }
    }
}
