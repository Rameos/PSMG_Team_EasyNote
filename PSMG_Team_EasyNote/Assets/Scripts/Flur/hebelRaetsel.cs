using UnityEngine;
using System.Collections;

public class hebelRaetsel : MonoBehaviour {
GameObject HLinks, HRechts, HMitte, RAussen, RMitte,RInnen, Schrank;
private int counter = 0;

   



	// Use this for initialization
	void Start () {
  
      
//HLinks = GameObject.FindGameObjectWithTag("hebelLinks");
//HRechts = GameObject.FindGameObjectWithTag("hebelRechts");
//HMitte = GameObject.FindGameObjectWithTag("hebelMitte");
//RAussen = GameObject.FindGameObjectWithTag("ringAussen");
//RInnen = GameObject.FindGameObjectWithTag("ringInnen");
//RMitte = GameObject.FindGameObjectWithTag("ringMitte");
	}
	
	// Update is called once per frame
	void Update () {

if( Input.GetMouseButtonDown(0) )
    {
       Ray ray = camera.ScreenPointToRay( Input.mousePosition );
       RaycastHit hit;

       if (Physics.Raycast(ray, out hit, 50))
       {
           moveLever();
           //Debug.Log(hit.transform.gameObject.tag);
       }

      
    }
    }

        void moveLever(){


                

        }

	
	
}
