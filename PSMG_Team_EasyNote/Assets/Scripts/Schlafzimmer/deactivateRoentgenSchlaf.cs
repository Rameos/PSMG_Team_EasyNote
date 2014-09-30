using UnityEngine;
using System.Collections;

public class deactivateRoentgenSchlaf : MonoBehaviour
{

    GameObject UV;
    GameObject Roentgen;

    // Use this for initialization
    void Start()
    {
        UV = GameObject.FindGameObjectWithTag("UV");
    }

    // Update is called once per frame
    //Durch Betätigen der Tasten springt der Spieler zurück in den normalen Modus.
    void Update()
    {
        if (Input.GetKey("r"))
        {
            Application.LoadLevel(3);
        }
        if (Input.GetKey("u"))
        {
            Application.LoadLevel(3);
            Destroy(UV);
        }
    }
}
