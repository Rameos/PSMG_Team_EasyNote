using UnityEngine;
using System.Collections;


/* 
 * Beischpielhafte anwendung des StateControllers
 */

public class ChangeMaterial : MonoBehaviour
{

    /// <summary>
    /// Materialien für die verschiedenen modi
    /// </summary>
    public Material NormalMaterial;
    public Material RoentgenMaterial;
    public Material UVMaterial;


    /// <summary>
    /// Wir setzen die Listener auf die Eventhandler. Je nach modus soll ein anderes Material gesetzt werden
    /// </summary>
    void Start()
    {
        StateManager.SetNormalModusHandler += changeToNormalModus;
        StateManager.SetRoentgenModusHandler += changeToRoentgenModus;
        StateManager.SetUVModusHandler += changeToUVModus;



    }

    /// <summary>
    /// Funktionen, die aufgerufen werden, wenn das Event gefeuert wird; Setzt entsprechende Materialien
    /// </summary>
    private void changeToNormalModus()
    {
        renderer.material = NormalMaterial;
    }

    private void changeToRoentgenModus()
    {
        renderer.material = RoentgenMaterial;
    }

    private void changeToUVModus()
    {
        renderer.material = UVMaterial;
    }
}
