using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class PackItems : MonoBehaviour
{


    private Rect inventoryWindowRect = new Rect(300, 100, 400, 400);
    private bool inventoryWindowShow = false;

    private GameObject item;

    ItemClass itemObject = new ItemClass();

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


            if (rayHit.collider.transform.tag == "Ball")
            {
                makeItemInvisible("Ball");
                putItemInInventory(itemObject.Ball.name);
            }

            if (rayHit.collider.transform.tag == "Spazierstock")
            {
                makeItemInvisible("Spazierstock");
                putItemInInventory(itemObject.Spazierstock.name);
            }

            if (rayHit.collider.transform.tag == "Säge")
            {
                makeItemInvisible("Säge");
                putItemInInventory(itemObject.Säge.name);
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
        while (InventoryGUI.inventoryNameDictionary[itemNumber] != string.Empty)
        {
            itemNumber++;

        }

        InventoryGUI.inventoryNameDictionary[itemNumber] = thing;


    }


    void makeItemInvisible(string name)
    {
        item = GameObject.FindGameObjectWithTag(name);
        item.renderer.enabled = false;


    }
}
