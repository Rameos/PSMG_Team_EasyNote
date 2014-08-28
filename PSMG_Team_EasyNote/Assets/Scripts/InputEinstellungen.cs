using UnityEngine;
using System.Collections;

/*
 Dieser Inputmanager löst nun entsprechend dem INput des Spielers/Nutzers die Events des StateManagers aus. Es ist Sinnvoll Input und Controller zu trennen, um schnell weitere inputmanager z.B. bauen zu können ohne die verarbeitende Mechanik zu verändern (= MVC)
 */

public class InputExample : MonoBehaviour
{

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R)
        {
            Debug.Log("X-Ray Mode");
            //Event wird nun gefeuert
            StateManager.OnSetRoentgenModus();
        }

        else if (Input.GetKeyUp(KeyCode.R))
        {
            Debug.Log("X-Ray Mode stop");
            //Event wird nun gefeuert
            StateManager.OnSetNormalModus);
        }


        if (Input.GetKeyDown(KeyCode.U))
        {
            Debug.Log("Heatmap Mode");
            //Event wird nun gefeuert
            StateManager.OnSetUVModus();
        }

        else if (Input.GetKeyUp(KeyCode.U))
        {
            Debug.Log("Heatmap Mode stop");
            //Event wird nun gefeuert
            StateManager.OnSetNormalModus();
        }
    }
}
