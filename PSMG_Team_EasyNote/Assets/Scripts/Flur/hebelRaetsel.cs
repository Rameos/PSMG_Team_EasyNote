using UnityEngine;

using System.Collections;

public class hebelRaetsel : MonoBehaviour
{
    GameObject HLinks, HRechts, HMitte, RAussen, RMitte, RInnen, Schrank, gameObjLinks;
    private int count1 = 0, count2 = 0, count3 = 0;
    private bool hasWon = false;
 

    float rotation = 0;
    float targetRotation = -90;
    float rotateSpeed = 5;




    // Use this for initialization
    void Start()
    {

        gameObjLinks = GameObject.FindGameObjectWithTag("gameObj");
        HLinks = GameObject.FindGameObjectWithTag("hebelLinks");
        HRechts = GameObject.FindGameObjectWithTag("hebelRechts");
        HMitte = GameObject.FindGameObjectWithTag("hebelMitte");
        RAussen = GameObject.FindGameObjectWithTag("ringAussen");
        RInnen = GameObject.FindGameObjectWithTag("ringInnen");
        RMitte = GameObject.FindGameObjectWithTag("ringMitte");

        HLinks.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

        checkWin();

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 50))
            {
                //checkWin();


                if (hit.transform.gameObject.tag == "hebelLinks")
                {

                    if (count1 == 4)
                    {
                        count1 = 1;

                    }
                    else
                    {
                        count1++;
                    }

                    moveLever(gameObjLinks, count1);
                }

                if (hit.transform.gameObject.tag == "hebelRechts")
                {


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
                    if (count2 == 4)
                    {
                        count2 = 1;
                    }
                    else
                    {
                        count2++;
                    }


                    moveLever(HMitte, count2);
                }
            }


        }
    }

    void moveLever(GameObject lever, int counter)
    {


        if (counter == 1 || counter == 2)
        {
            moveDown(lever);
        }


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
            
            //variable übergeben, in script wird erst getestet ob variable true oder false und dann erst ausgeführt

            ScheibenDrehen drehen = RMitte.GetComponent<ScheibenDrehen>();
            //drehen.Update();
         //  RMitte.transform.Rotate(0, 0, -90);

           // mitte viertel guz, innen viertel uz
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
        //checkWin();

    }

    void rotateRingsWhenDown(GameObject lever)
    {
        if (lever == gameObjLinks)
        {

            //außen dreviertel uz, mitte halb uz
            RAussen.transform.Rotate(0, 0, 270);
            RMitte.transform.Rotate(0, 0, 180);

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
        // checkWin();

    }

    void checkWin()
    {

        TriggerAussen triggerAussen = RAussen.GetComponent<TriggerAussen>();
        TriggerInnen triggerInnen = RInnen.GetComponent<TriggerInnen>();
        TriggerMitte triggerMitte = RMitte.GetComponent<TriggerMitte>();


        if (triggerAussen.RAinRightPos == true && triggerMitte.RMinRightPos == true && triggerInnen.RIinRightPos == true)
        {
            hasWon = true;
        }

        else
        {
            hasWon = false;
        }


    }

}
