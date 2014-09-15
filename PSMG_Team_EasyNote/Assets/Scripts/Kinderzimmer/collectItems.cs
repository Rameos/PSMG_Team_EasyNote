using UnityEngine;
using System.Collections;

public class collectItems : MonoBehaviour {

    void start()
    {
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Destroy(gameObject);
        }
    }
    
}
