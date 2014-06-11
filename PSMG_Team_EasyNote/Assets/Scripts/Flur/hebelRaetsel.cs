using UnityEngine;
using System.Collections;

public class hebelRaetsel : MonoBehaviour {
    GameObject HLinks, HRechts, HMitte, RAussen, RMitte, RInnen, Schrank, gameObjLinks;
private int count1 = 0, count2 = 0, count3 = 0;


   



	// Use this for initialization
	void Start () {

        gameObjLinks = GameObject.FindGameObjectWithTag("gameObj");
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
          
           //Debug.Log(hit.transform.gameObject.tag);
          
           if (hit.transform.gameObject.tag == "hebelLinks")
           {
               Debug.Log("Linker Hebel wurde geklickt");
               if (count1== 4)
               {
                   count1 = 1;
                   Debug.Log("count1 ist 1");
               }
               else
               {
                   count1++;
               }

               Debug.Log(count1);
               moveLever(gameObjLinks, count1);
           }

           if (hit.transform.gameObject.tag == "hebelRechts")
           {
               Debug.Log(" Hebel rechts wurde geklickt");

               if (count3 == 4)
               {
                   count3 = 1;
               }
               else
               {
                   count3++;
               }
               
          
               moveLever(HRechts, count3);
           }

           if (hit.transform.gameObject.tag == "hebelMitte")
           {
               Debug.Log(" Hebel Mitte wurde geklickt");
               if (count2 == 4)
               {
                   count2 = 1;
               }
               else {
                   count2++;
               }
               
               
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
           lever.transform.Rotate(0, -40, 0);
           rotateRingsWhenUp(lever);
            

        }

        void moveUp(GameObject lever)
        {
            lever.transform.Rotate(0, 40, 0);
            rotateRingsWhenDown(lever);

        }


        void rotateRingsWhenUp(GameObject lever)
        {
            if (lever == gameObjLinks)
            {
                //mitte viertel guz, innen viertel uz
            }

            if (lever == HMitte)
            {
                //mitte halb guz
            }

            if (lever == HRechts)
            {
                //innen halb guz
            }

        }

        void rotateRingsWhenDown(GameObject lever)
        {
            if (lever == gameObjLinks)
            {
                //außen dreviertel uz, mitte halb uz
            }

            if (lever == HMitte)
            {
                //mitte viertel guz, innen halb guz
            }

            if (lever == HRechts)
            {
                //innen viertel uz, mitte halb guz
            }

        }
}
