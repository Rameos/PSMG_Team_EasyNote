using UnityEngine;
using System.Collections;

public class guiText : MonoBehaviour {
    bool showLabel = false;
    public GUIStyle style;
    public GUISkin GUISkin;
    private BildAnim bildAnim;
  
	// Use this for initialization
	void Start () {
        GameObject bild = GameObject.FindGameObjectWithTag("bild");
        bildAnim = bild.GetComponent<BildAnim>(); 
	}
	
	// Update is called once per frame
	void Update () {
        OnGUI();
	}

    public void ToggleLabel()
    {
        showLabel = !showLabel;
    }

    void OnGUI()
    {
        GUI.skin = GUISkin; 

        if (showLabel)
        {
            GUI.skin = GUISkin;

           

                GUI.Label(new Rect(Screen.width / 2 - 100, 0, 200, 50), "Hier ist leider nichts!");
                //GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 400, 100), "Hier ist leider nichts!", style);
                //GUILayout.Label("Hier ist leider nichts");
            
        }
        else
        {
            GUI.Label(new Rect(0,0, 0,0), "");
        }

    }

    void OnMouseDown()
    {
        Invoke("ToggleLabel", 1);
        Invoke("ToggleLabel", 3);
    }
}
