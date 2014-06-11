using UnityEngine;
using System.Collections;

public class hebelRaetsel : MonoBehaviour {
GameObject HLinks, HRechts, HMitte, RAussen, RMitte,RInnen, Schrank;
private int count1 = 0, count2 = 0, count3 = 0;

   



	// Use this for initialization
	void Start () {


        HLinks = GameObject.FindGameObjectWithTag("hebelLinks");
        HRechts = GameObject.FindGameObjectWithTag("hebelRechts");
        HMitte = GameObject.FindGameObjectWithTag("hebelMitte");
        RAussen = GameObject.FindGameObjectWithTag("ringAussen");
        RInnen = GameObject.FindGameObjectWithTag("ringInnen");
        RMitte = GameObject.FindGameObjectWithTag("ringMitte");
	}
	
	// Update is called once per frame
	void Update () {

if( Input.GetMouseButtonDown(0) )
    {
       Ray ray = camera.ScreenPointToRay( Input.mousePosition );
       RaycastHit hit;

       if (Physics.Raycast(ray, out hit, 50))
       {
          // moveLever();
           //Debug.Log(hit.transform.gameObject.tag);
           if (hit.transform.gameObject.tag == "hebelLinks")
           {
               Debug.Log("Linker Hebel wurde geklickt");
               count1++;
               moveLever(HLinks, count1);
           }

           if (hit.transform.gameObject.tag == "hebelRechts")
           {
               count3++;
               moveLever(HRechts, count3);
           }

           if (hit.transform.gameObject.tag == "hebelMitte")
           {
               count2++;
               moveLever(HMitte, count2);
           }
       }

      
    }
    }

        void moveLever(GameObject lever, int counter){
            if (counter == 1 || counter == 2)
            {
                moveDown(lever);
            }
            Debug.Log(lever+ "Bewegung");

            if (counter == 3 || counter == 4)
            {
                moveUp(lever);
            }
        }

        void moveDown(GameObject lever)
        {


        }

        void moveUp(GameObject lever)
        {


        }
	
	
}
