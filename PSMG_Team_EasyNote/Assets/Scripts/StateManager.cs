using UnityEngine;
using System.Collections;


/*
  Wir nutzen die Events dazu, um die verschiedenen Modi des Spiels zu triggern. Jedes Script kann über diese events angetriggert werden, ein bestimmtes Verhalten zu starten/beenden, wenn der modus gewechselt wird. 
    (z.B. materialwechsel, Soundwechsel, effektstarts usw.)
 */

// Delegaten für die Events;
public delegate void SetNormalModus();
public delegate void SetRoentgenModus();
public delegate void SetUVModus();


public class StateManager : MonoBehaviour {

    //Events, die abgefeuert werden, um die Materialien anzutriggern
    public static event SetNormalModus SetNormalModusHandler;
    public static event SetRoentgenModus SetRoentgenModusHandler;
    public static event SetUVModus SetUVModusHandler;


    /// <summary>
    /// Start nutzen Wir, um alle Objekte einmal in den Normalzustand zu versetzen
    /// </summary>
    void Start()
    {
        OnSetNormalModus();
    }


    /// <summary>
    /// Statische Funktionen, die extern aufgerufen werden, wenn der Modus gewechselt wird
    /// </summary>
    public static void OnSetNormalModus()
    {
        if (SetNormalModusHandler != null)
        {
            SetNormalModusHandler();
        }
    }

    public static void OnSetRoentgenModus()
    {
        if (SetRoentgenModusHandler!= null)
        {
            SetRoentgenModusHandler();
        }
    }

    public static void OnSetUVModus()
    {
        if (SetUVModusHandler != null)
        {
            SetUVModusHandler();
        }
    }
}
