using UnityEngine;

using System.Collections;

public class HebelRaetsel : MonoBehaviour
{
    GameObject HLinks, HRechts, HMitte, RAussen, RMitte, RInnen, Schrank, gameObjLinks, reset;
    private int count1 = 0, count2 = 0, count3 = 0;
    public bool hasWon = false;
    private bool closed = false;

    public bool visible = false;
 

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
        reset = GameObject.FindGameObjectWithTag("reset");
        Schrank = GameObject.FindGameObjectWithTag("korpus");

       

    }

    // Update is called once per frame
    void Update()
    {

        if (visible)
        {
            Debug.Log("sichtbar");
            HLinks.SetActive(true);
            HLinks.renderer.enabled = true;
        }
        //else
        //{
        //    HLinks.SetActive(true);
        //}

        checkWin();

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
           // Debug.Log("mouse down");
            if (Physics.Raycast(ray, out hit, 50))
            {


                if (hit.transform.gameObject.tag == "hebelLinks")
                {
                    Debug.Log("hebel links");
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

                    Debug.Log("hebel rechts");
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



                if (hit.transform.gameObject.tag == "reset")
                {
                    Debug.Log("reset");
                    gameObjLinks.transform.localEulerAngles = new Vector3(320, 180, 90);
                    HMitte.transform.localEulerAngles = new Vector3(331, 270, 90);
                    HRechts.transform.localEulerAngles = new Vector3(331, 270, 90);

                    RAussen.transform.localEulerAngles = new Vector3(0, 270, 90);
                    RMitte.transform.localEulerAngles = new Vector3(0, 270, 180);
                    RInnen.transform.localEulerAngles = new Vector3(0, 270, 270);
                    count1 = 0;
                    count2 = 0;
                    count3 = 0;
                }
            }


        }
    }

    void moveLever(GameObject lever, int counter)
    {
        Camera.main.audio.Play();

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

           // ScheibenDrehen drehen = RMitte.GetComponent<ScheibenDrehen>();
            //drehen.Update();
          RMitte.transform.Rotate(0, 0, -90);

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
            Debug.Log("gewonnen");

            if (closed == false)
            {
                Debug.Log(Schrank.animation.Play("shutDoors"));
                Schrank.animation.Play("shutDoors");
                closed = true;
            }
            
        }

        else
        {
            hasWon = false;
            
        }


    }
  

}
