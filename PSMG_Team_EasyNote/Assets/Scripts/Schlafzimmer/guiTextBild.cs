using UnityEngine;
using System.Collections;

public class guiTextBild : MonoBehaviour {

    bool showLabel = false;
    public GUIStyle style;
    public GUISkin GUISkin;
    private BildAnim bildAnim;

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

        if (showLabel)
        {
            GUI.skin = GUISkin;

            if (gameObject.tag == "bild" && bildAnim.PicOpen == true)
            {
                GUI.Label(new Rect(Screen.width / 2 - 150, 0, 300, 50), "Du hast einen Hammer gefunden");
            }

            else
            {
                GUI.Label(new Rect(0, 0, 0, 0), "");
            }

        }
    }

    void OnMouseDown()
    {
        Invoke("ToggleLabel", 1);
        Invoke("ToggleLabel", 3);
    }
}