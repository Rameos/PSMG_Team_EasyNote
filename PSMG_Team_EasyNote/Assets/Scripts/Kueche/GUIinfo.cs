using UnityEngine;
using System.Collections;

public class GUIinfo : MonoBehaviour {
	
	bool showLabel = false;
	string helpText;
	public GUISkin GUISkin;
	
	private bool shown = false;
	// Use this for initialization
	void Start()
	{
		Invoke("ToggleLabel", 1);
		Invoke("ToggleLabel", 6);
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
			
			GUI.Label(new Rect(Screen.width / 2 - 200, 0, 500, 100), "Was für eine Sauerei... Wer hat denn hier gewütet?!");
			//showText();
		}
		else
		{
			GUI.Label(new Rect(0, 0, 0, 0), "");
		}
		
		GUI.Label(new Rect(0, 0, 500, 100), "Mit den Tasten '1', '2', '3' und '4' kannst \ndu die Kameraperspektive verändern.");
	}
	
	
	
	
}