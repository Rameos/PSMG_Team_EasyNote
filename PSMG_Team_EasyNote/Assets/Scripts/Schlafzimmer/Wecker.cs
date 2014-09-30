using UnityEngine;
using System.Collections;

public class Wecker : MonoBehaviour {

    GameObject zb;
    public bool ringing = false;
    public bool destroyed = false;
    guiTextWecker guiWecker;
    private bool sent = false;

	// Use this for initialization
	void Start () {
        zb = GameObject.FindGameObjectWithTag("ziffernblatt");
        guiWecker = zb.GetComponent<guiTextWecker>();
	}
	
	// Update is called once per frame
    // Wird der Wecker zerstört, erhält der Spieler eine Gewinnbenachrichtigung und der Wecker hört auf zu läuten. Anschließend wird
    // das nächste Level automatisch geladen. 
    void Update()
    {
        if (destroyed == true)
        {
            zb.audio.Stop();
            if (sent == false)
            {
                guiWecker.printNewText("Der Wecker hat aufgehört zu läuten!");
                sent = true;
            }
            
            Invoke("Load", 7);
        }

    }

    void OnMouseDown()
    {
        zb.audio.Play();
        ringing = true;
    }

    void Load()
    {
        Application.LoadLevel(5);
    }
}


