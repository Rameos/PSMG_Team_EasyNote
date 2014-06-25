using UnityEngine;
using System.Collections;

public class objectfound : MonoBehaviour {

    void Start()
    {
        var showText = true;
        var textArea = new Rect(0,0,Screen.width, Screen.height);
 
        function OnGUI()
        {
 
            if(showText)
            {
            GUI.Label(textArea,"Finde alle Gegenstände!\nlalalala\nanother line\nI could do this all day!");
            }
        }
        Debug.Log("Finde alle Gegenstände!");
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
