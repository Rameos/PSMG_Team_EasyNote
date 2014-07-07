using UnityEngine;
using System.Collections;


/*
  Wir nutzen die Events dazu, um die verschiedenen Modi des Spiels zu triggern. Jedes Script kann über diese events angetriggert werden, ein bestimmtes Verhalten zu starten/beenden, wenn der modus gewechselt wird. 
    (z.B. materialwechsel, Soundwechsel, effektstarts usw.)
 */

// Delegaten für die Events;
public delegate void SetNormalMode();
public delegate void SetXRayMode();
public delegate void SetHeatmapMode();


public class StateManager : MonoBehaviour {

    //Events, die abgefeuert werden, um die Materialien anzutriggern
    public static event SetNormalMode SetNormalModeHandler;
    public static event SetXRayMode SetXRayModeHandler;
    public static event SetHeatmapMode SetHeatmapModeHandler;


    /// <summary>
    /// Start nutzen Wir, um alle Objekte einmal in den Normalzustand zu versetzen
    /// </summary>
    void Start()
    {
        OnSetNormalMode();
    }


    /// <summary>
    /// Statische Funktionen, die extern aufgerufen werden, wenn der Modus gewechselt wird
    /// </summary>
    public static void OnSetNormalMode()
    {
        if (SetNormalModeHandler != null)
        {
            SetNormalModeHandler();
        }
    }

    public static void OnSetXrayMode()
    {
        if (SetXRayModeHandler!= null)
        {
            SetXRayModeHandler();
        }
    }

    public static void OnSetHeatmapMode()
    {
        if (SetHeatmapModeHandler != null)
        {
            SetHeatmapModeHandler();
        }
    }
}
