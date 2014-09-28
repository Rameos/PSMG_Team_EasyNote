using UnityEngine;
using System.Collections;

public class LichtAus : MonoBehaviour {

    bool flashlightOn = false;
	// Use this for initialization
	void Start () {

       


	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("flashlight on" + flashlightOn);

        if (Input.GetKeyDown(KeyCode.F) && flashlightOn == false)
        {
            Debug.Log("Licht aus, Taschenlampe an");
            light.intensity = 0f;
            RenderSettings.ambientLight = Color.black;
            flashlightOn = true;
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.F) && flashlightOn == true)
            {
                Debug.Log("Licht an");

                Color colorGrey = new Color(0.2f,0.2f,0.2f);
                RenderSettings.ambientLight = colorGrey;
               

                Debug.Log(RenderSettings.ambientLight);
                light.intensity = 0.19f;
                flashlightOn = false;
            }

        }


	}
}
