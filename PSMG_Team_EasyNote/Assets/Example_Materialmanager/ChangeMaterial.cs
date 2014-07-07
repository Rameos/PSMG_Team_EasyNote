using UnityEngine;
using System.Collections;


/* 
 * Beischpielhafte anwendung des StateControllers
 */

public class ChangeMaterial : MonoBehaviour {

    /// <summary>
    /// Materialien für die verschiedenen modi
    /// </summary>
    public Material normalMaterial;
    public Material xRayMaterial;
    public Material heatmapMaterial;


    /// <summary>
    /// Wir setzen die Listener auf die Eventhandler. Je nach modus soll ein anderes Material gesetzt werden
    /// </summary>
	void Start () {

        StateManager.SetHeatmapModeHandler += changeToHeatmapMode;
        StateManager.SetNormalModeHandler += changeToNormalMode;
        StateManager.SetXRayModeHandler+= changeToXRayMode;
 
	}
	
    /// <summary>
    /// Funktionen, die aufgerufen werden, wenn das Event gefeuert wird; Setzt entsprechende Materialien
    /// </summary>
    private void changeToNormalMode()
    {
        renderer.material = normalMaterial; 
    }

    private void changeToXRayMode()
    {
        renderer.material = xRayMaterial;
    }

    private void changeToHeatmapMode()
    {
        renderer.material = heatmapMaterial;
    }
}
