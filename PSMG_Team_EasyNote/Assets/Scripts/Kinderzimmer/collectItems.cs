using UnityEngine;
using System.Collections;


public class collectItems : MonoBehaviour
{
    //private GameObject item;
    string nachricht = "Suche die angegebenen vier Gegenstände!";
    string stifttuerkis = "Türkiser Stift";
    string rubikCube = "Rubik's Cube";
    string docs = "Dokumentenstapel";
    string autogelb = "Gelbes Auto";
    bool gefunden = false;
    int anzahlGefObj = 0;


    void Start()
    {

    }

    void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 2 - 200, 0, 500, 100), nachricht);
        GUI.Label(new Rect(Screen.width / 2 - 200, 0, 500, 100), stifttuerkis);
        GUI.Label(new Rect(Screen.width / 2 - 200, 0, 500, 100), rubikCube);
        GUI.Label(new Rect(Screen.width / 2 - 200, 0, 500, 100), docs);
        GUI.Label(new Rect(Screen.width / 2 - 200, 0, 500, 100), autogelb);
    }
   
    void Update()
    {
       
        
    }
   
    void OnMouseDown()
    {
        Destroy(this.gameObject);

        

    }
}

