using UnityEngine;
using System.Collections;

public class Wecker : MonoBehaviour {

    GameObject zb;
    public bool ringing = false;
    public bool destroyed = false;
    guiTextWecker guiWecker;

	// Use this for initialization
	void Start () {
        zb = GameObject.FindGameObjectWithTag("ziffernblatt");
	}
	
	// Update is called once per frame
    void Update()
    {
        if (destroyed == true)
        {
            zb.audio.Stop();
            //guiWecker.printNewText("Der Wecker hat aufgehört zu läuten...\nDu kannst weitergehen...");
            Invoke("Load", 3);
        }

    }

    void OnMouseDown()
    {
        zb.audio.Play();
        ringing = true;
        Debug.Log(gameObject.tag);
    }

    void Load()
    {
        Application.LoadLevel(5);
    }
}


