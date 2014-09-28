using UnityEngine;
using System.Collections;

public class Nachrichten : MonoBehaviour
{
    string nachricht;
    GameObject buch;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 50))
            {

                if (hit.transform.gameObject.tag == "kanne")
                {
                    nachricht = "Der Tee ist kalt.";

                }


                if (hit.transform.gameObject.tag == "buch")
                {
                    nachricht = "Das ist jetzt nicht so interessant";
                }

                if (hit.transform.gameObject.tag == "Vase")
                {
                    nachricht = "Klappert darin nicht etwas?";
                }


                if (hit.transform.gameObject.tag == "schalter")
                {
                    nachricht = "Der Fernseher ist schon alt. Die Knöpfe zum Umschalten funktionieren nicht mehr.";
                }




            }
        }

    }







    void OnGui()
    {
        GUI.Label(new Rect(Screen.width / 2 - 200, 50, 500, 100), nachricht);
        GUI.Label(new Rect(Screen.width / 2 - 200, 0, 500, 100), "Mit der 'R'-Taste schaltest du den Röntgenblick ein. \nMit der 'U'-Taste kommst du in den UV-Modus. \nZurück geht's mit 'N'.");
    }
}
