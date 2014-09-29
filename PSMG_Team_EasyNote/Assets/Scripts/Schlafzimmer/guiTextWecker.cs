using UnityEngine;
using System.Collections;

public class guiTextWecker : MonoBehaviour {

    bool showLabel = false;
    public GUIStyle style;
    public GUISkin GUISkin;
    private BildAnim bildAnim;
    private bool shown = false;
    private string text = "Der Wecker hat angefangen zu klingeln...\nWie kann man wieder für Ruhe sorgen??";

    // Use this for initialization
    void Start()
    {
        GameObject bild = GameObject.FindGameObjectWithTag("bild");
        bildAnim = bild.GetComponent<BildAnim>();
    }

    // Update is called once per frame
    void Update()
    {
        OnGUI();
    }

    public void ToggleLabel()
    {
        showLabel = !showLabel;
    }

    void OnGUI()
    {
        GUI.skin = GUISkin;

        if (showLabel && shown == false)
        {
            GUI.skin = GUISkin;


            GUI.Label(new Rect(Screen.width/2 - 175, 0, 350, 100), text);
                
        }


            else
            {
                GUI.Label(new Rect(0, 0, 0, 0), "");
            }

        }
    

    void OnMouseDown()
    {
        Invoke("ToggleLabel", 1);
        Invoke("ToggleLabel", 5);
        Invoke("ToggleBool", 5);

    }

    void ToggleBool()
    {
        shown = true;
    }

    public void printNewText(string newText)
    {
        text = newText;
    }
}