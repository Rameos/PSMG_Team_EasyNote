using UnityEngine;
using System.Collections;

public class LichtAus : MonoBehaviour
{

    bool flashlightOn = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F) && flashlightOn == false)
        {

            light.intensity = 0f;
            RenderSettings.ambientLight = Color.black;
            flashlightOn = true;
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.F) && flashlightOn == true)
            {

                Color colorGrey = new Color(0.2f, 0.2f, 0.2f);
                RenderSettings.ambientLight = colorGrey;
                light.intensity = 0.19f;
                flashlightOn = false;
            }

        }


    }
}
