using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class collectItems : MonoBehaviour
{
    private GameObject item;

    private Ray mouseRay;
    private RaycastHit rayHit;


    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButtonDown(0) && Physics.Raycast(mouseRay, out rayHit))
        {

            // Physics.Raycast(mouseRay, out rayHit);
            //Debug.Log(rayHit.collider.transform.tag);

            if (rayHit.collider.transform.tag == "AutoGelb")
            {
                makeItemInvisible("Autogelb");
            }

            if (rayHit.collider.transform.tag == "RubikCube")
            {
                makeItemInvisible("RubikCube");
                
            }

            if (rayHit.collider.transform.tag == "Stifttuerkis")
            {
                makeItemInvisible("Stifttuerkis");
            }

            if (rayHit.collider.transform.tag == "Docs")
            {
                makeItemInvisible("Docs");
            }

            else
            {
                //Do nothing

            }
        }

    }
   
    void makeItemInvisible(string name)
    {
        item = GameObject.FindGameObjectWithTag(name);
        //item.SetActive(false);
        item.renderer.enabled = false;
        

    }
}

