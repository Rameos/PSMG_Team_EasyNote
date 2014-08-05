using UnityEngine;
using System.Collections;

public class SchrankAnim : MonoBehaviour {

    GameObject tl;
    GameObject tr;
	// Use this for initialization
	void Start () {
	
	}

   

    // Update is called once per frame
    void OnMouseDown()
    {
        
            tl = GameObject.FindGameObjectWithTag("tuerLinks");
            tr = GameObject.FindGameObjectWithTag("tuerRechts");
            tl.animation.Play("tuerLinksAnim");
            tr.animation.Play("tuerRechtsAnim");
                    
    }
}
