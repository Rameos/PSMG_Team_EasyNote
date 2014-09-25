using UnityEngine;
using System.Collections;

public class CollectItemsSolve : MonoBehaviour
{

    string aufgabe = "Suche die angegebenen vier Gegenstände!";
    string stifttuerkis = "Türkiser Stift";
    string rubikCube = "Rubik's Cube";
    string docs = "Dokumentenstapel";
    string autogelb = "Gelbes Auto";
    bool gefundenRubikCube = false;
    bool gefundenAutogelb = false;
    bool gefundenDocs = false;
    bool gefundenStifttuerkis = false;
    int anzahlGefObj = 0;

    void Start()
    {

    }

    void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 100, 0, 500, 100), aufgabe);
        GUI.Label(new Rect(Screen.width / 2 - 400, 0, 100, 100), stifttuerkis);
        GUI.Label(new Rect(Screen.width / 2 - 300, 0, 100, 100), rubikCube);
        GUI.Label(new Rect(Screen.width / 2 - 200, 0, 150, 150), docs);
        GUI.Label(new Rect(Screen.width / 2 - 70, 0, 100, 100), autogelb);
    }

    void Update()
    {
        if (anzahlGefObj == 4)
        {
           // GUI.Button(new Rect(10, 70, 50, 30), "nächstes Level");
            Application.LoadLevel(2);
        }

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 50))
            {

                if (hit.transform.gameObject.tag == "Docs")
                {
                    Destroy(GameObject.FindWithTag("Docs"));
                    gefundenDocs = true;
                    anzahlGefObj = anzahlGefObj + 1;
                    Debug.Log(anzahlGefObj);
                }


                if (hit.transform.gameObject.tag == "Stifttuerkis") 
                {
                    Destroy(GameObject.FindWithTag("Stifttuerkis"));
                    gefundenStifttuerkis = true;
                    anzahlGefObj = anzahlGefObj + 1;
                    Debug.Log(anzahlGefObj);
                }

                if (hit.transform.gameObject.tag == "Autogelb")
                {
                    Destroy(GameObject.FindWithTag("Autogelb"));
                    gefundenAutogelb = true;
                    anzahlGefObj = anzahlGefObj + 1;
                    Debug.Log(anzahlGefObj);
                }

                if (hit.transform.gameObject.tag == "RubikCube")
                {
                    Destroy(GameObject.FindWithTag("RubikCube"));
                    gefundenRubikCube = true;
                    anzahlGefObj = anzahlGefObj + 1;
                    Debug.Log(anzahlGefObj);
                }

                

            }
        }
        
    }
}
