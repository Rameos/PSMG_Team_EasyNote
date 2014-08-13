using UnityEngine;
using System.Collections;

public class SchrankAnim : MonoBehaviour {

    GameObject tl;
    GameObject tr;
    bool showLabel = false;

	// Use this for initialization
	void Start () {
        
	}


    void Update()
    {
      
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
