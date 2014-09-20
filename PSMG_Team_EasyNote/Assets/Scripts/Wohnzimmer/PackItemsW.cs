using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class PackItemsW : MonoBehaviour
{


    private Rect inventoryWindow = new Rect(300, 100, 400, 400);
    private bool inventoryWindowShow = false;

    private GameObject objekt;

    ItemClass itemObjectNew = new ItemClass();

    private Ray mouseRay;
    private RaycastHit rayHit;

    private Dictionary<int, string> lootDictionary = new Dictionary<int, string>()
    {
        {0, string.Empty},
         {1, string.Empty},
          {2, string.Empty},
           {3, string.Empty},
           {4, string.Empty},
         {5, string.Empty},
    };



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

            if (rayHit.collider.transform.tag == "Ball")
            {
                makeItemInvisible("Ball");
                putItemInInventory(itemObjectNew.Ball.name);
            }

            if (rayHit.collider.transform.tag == "Spazierstock")
            {
                makeItemInvisible("Spazierstock");
                putItemInInventory(itemObjectNew.Spazierstock.name);
            }

            if (rayHit.collider.transform.tag == "Säge")
            {
                makeItemInvisible("Säge");
                putItemInInventory(itemObjectNew.Säge.name);
            }

            else
            {
                //Do nothing

            }
        }

    }





    void putItemInInventory(string thing)
    {
        int itemNumber = 0;
        while (InventarGUI.inventoryNameDictionaryW[itemNumber] != string.Empty)
        {
            itemNumber++;

        }

        InventarGUI.inventoryNameDictionaryW[itemNumber] = thing;
        //item.collider.enabled = false;


    }


    void makeItemInvisible(string name)
    {
        objekt = GameObject.FindGameObjectWithTag(name);
        //item.SetActive(false);
        objekt.renderer.enabled = false;


    }
}
