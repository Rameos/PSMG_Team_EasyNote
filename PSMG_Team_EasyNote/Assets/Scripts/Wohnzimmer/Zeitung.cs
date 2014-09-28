using UnityEngine;
using System.Collections;

public class Zeitung : MonoBehaviour
{

    GameObject zeitungGroß;
    bool showButton = true;

    // Use this for initialization
    void Start()
    {
        zeitungGroß = GameObject.FindGameObjectWithTag("zeitung");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {

        zeitungGroß.renderer.enabled = true;

    }

    void OnGUI()
    {
        if (showButton)
        {

            if (GUI.Button(new Rect(20, 40, 80, 20), "Zurück"))
            {
                zeitungGroß.renderer.enabled = false;
                showButton = false;

            }

        }

    }

}
