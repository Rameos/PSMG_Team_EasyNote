using UnityEngine;
using System.Collections;

public class collect : MonoBehaviour {

    void OnMouseDown()
    {
        Debug.Log("Objekt wird im Inventar plaziert");
        Color greenColour = new Color(0, 102, 0);
        renderer.material.color = greenColour;
    }

}
