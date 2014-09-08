using UnityEngine;
using System.Collections;

public class Wecker : MonoBehaviour {

    GameObject zb;
    public bool ringing = false;
    public bool destroyed = false;

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
        }

    }

    void OnMouseDown()
    {
        zb.audio.Play();
        ringing = true;
        Debug.Log(gameObject.tag);
    }
}
