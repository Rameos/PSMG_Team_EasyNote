using UnityEngine;
using System.Collections;

public class objectfound : MonoBehaviour {

    void Start()
    {
        Debug.Log("Finde 5 Gegenstände!");
    }

    void OnMouseDown()
    {
        //if(int anzahlliste=0){

            //anzahlliste++;
        //}
        Debug.Log("Du hast ein Objekt gefunden!");
        Color greenColour = new Color(0, 102, 0);
        renderer.material.color = greenColour;
    }
}
