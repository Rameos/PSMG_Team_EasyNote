using UnityEngine;
using System.Collections;

/*
 Dieser Inputmanager löst nun entsprechend dem INput des Spielers/Nutzers die Events des StateManagers aus. Es ist Sinnvoll Input und Controller zu trennen, um schnell weitere inputmanager z.B. bauen zu können ohne die verarbeitende Mechanik zu verändern (= MVC)
 */

public class InputExample : MonoBehaviour {

	void Update () {

        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("X-Ray Mode");
            //Event wird nun gefeuert
            StateManager.OnSetXrayMode();
        }

        else if (Input.GetKeyUp(KeyCode.W))
        {
            Debug.Log("X-Ray Mode stop");
            //Event wird nun gefeuert
            StateManager.OnSetNormalMode();
        }


        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Heatmap Mode");
            //Event wird nun gefeuert
            StateManager.OnSetHeatmapMode();
        }

        else if (Input.GetKeyUp(KeyCode.Q))
        {
            Debug.Log("Heatmap Mode stop");
            //Event wird nun gefeuert
            StateManager.OnSetNormalMode();
        }
	}
}
