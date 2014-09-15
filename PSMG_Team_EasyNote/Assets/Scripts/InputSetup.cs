using UnityEngine;
using System.Collections;

public class InputSetup : MonoBehaviour
{

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("X-Ray Mode");
            //Event wird nun gefeuert
            StateManager.OnSetRoentgenModus();
        }

        else if (Input.GetKeyUp(KeyCode.R))
        {
            Debug.Log("X-Ray Mode stop");
            //Event wird nun gefeuert
            StateManager.OnSetNormalModus();
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