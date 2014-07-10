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

        //checkWin();

if( Input.GetMouseButtonDown(0) )
    {
       Ray ray = camera.ScreenPointToRay( Input.mousePosition );
       RaycastHit hit;

       if (Physics.Raycast(ray, out hit, 50))
       {
          
           //Debug.Log(hit.transform.gameObject.tag);
          
           if (hit.transform.gameObject.tag == "hebelLinks")
           {
               //Debug.Log("Linker Hebel wurde geklickt");
               if (count1== 4)
               {
                   count1 = 1;
                 
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
               //Debug.Log(" Hebel rechts wurde geklickt");

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
               //Debug.Log(" Hebel Mitte wurde geklickt");
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
            //Debug.Log(lever+ "Bewegung");

            if (counter == 3 || counter == 4)
            {
                moveUp(lever);
            }
        }

        void moveDown(GameObject lever)
        {
           lever.transform.Rotate(0, -40, 0);
           rotateRingsWhenDown(lever);
            

        }

        void moveUp(GameObject lever)
        {
            lever.transform.Rotate(0, 40, 0);
            rotateRingsWhenUp(lever);

        }


        void rotateRingsWhenUp(GameObject lever)
        {
            if (lever == gameObjLinks)
            {
                RMitte.transform.Rotate(0, 0, -90);
               // Debug.Log("Euler" +RMitte.transform.eulerAngles.x);
              //  RInnen.transform.Rotate(0, 0, 90);
                //mitte viertel guz, innen viertel uz
            }

            if (lever == HMitte)
            {
                //außen viertel guz
                RAussen.transform.Rotate(0, 0, -90);
                
            }

            if (lever == HRechts)
            {
                //innen halb guz
                RInnen.transform.Rotate(0, 0, -180);
            }
            checkWin();

        }

        void rotateRingsWhenDown(GameObject lever)
        {
            if (lever == gameObjLinks)
            {
                
                //außen dreviertel uz, mitte halb uz
                RAussen.transform.Rotate(0, 0, 270);
                RMitte.transform.Rotate(0, 0, 180);
                //Debug.Log("Euler" + RMitte.transform.eulerAngles.x + "y" + RMitte.transform.eulerAngles.y + "z" + RMitte.transform.eulerAngles.z);
            }

            if (lever == HMitte)
            {
                //mitte viertel guz, innen halb guz
                RMitte.transform.Rotate(0, 0, -90);
                RAussen.transform.Rotate(0, 0, -180);
            }

            if (lever == HRechts)
            {
                //innen viertel uz, mitte halb guz
                RInnen.transform.Rotate(0, 0, 90);
                RMitte.transform.Rotate(0, 0, -180);
            }
            checkWin();

        }

        void checkWin()
        {
            double RAx= 0;
            double RAz = -1.001791E-05f;
            double RMx = 1.707546E-06f;
            double RMz = 5.122643E-06f;
            double RIx = 0f;
            double RIz = 0f;

            double getRAx = RAussen.transform.eulerAngles.x;
            double getRAz = RAussen.transform.eulerAngles.z;
            double getRMx = RMitte.transform.eulerAngles.x;
            double getRMz = RMitte.transform.eulerAngles.z;
            double getRIx = RInnen.transform.eulerAngles.x;
            double getRIz = RInnen.transform.eulerAngles.x;

            Debug.Log("EulerA" + RAussen.transform.eulerAngles.x + "z" + RAussen.transform.eulerAngles.z);
            Debug.Log("setA" + getRAx + "z" + getRAz);
            Debug.Log("EulerM" + RMitte.transform.eulerAngles.x +  "z" + RMitte.transform.eulerAngles.z);
            Debug.Log("setM" + getRMx + "z" + getRMz);
            Debug.Log("EulerI" + RInnen.transform.eulerAngles.x + "z" + RInnen.transform.eulerAngles.z);

            
          
            Debug.Log("setI" + getRIx + "z" + getRIz);

            if (RAx == getRAx && RAz == getRAz && RMx == getRMx && RMz == getRMz && RIx == getRIx && RIz == getRIz)
            {
                Debug.Log("gewonnen!");
            }
            else
                Debug.Log("lose!");
        }


}
