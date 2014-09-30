using UnityEngine;
using System.Collections;

public class activateRoentgenSchlaf : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    //Durch Betätigen der jeweiligen Taste wechselt der Spieler in den Röntgen- bzw. UV-Modus
    void Update()
    {
        if (Input.GetKey("r"))
        {
            Application.LoadLevel(15);
        }
        if (Input.GetKey("u"))
        {
            Application.LoadLevel(16);
        }
    }
}
