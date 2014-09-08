using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class CorpseLoot : MonoBehaviour
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

        //display dictionary
        lootDictionary[0] = itemObject.saege.name;
        lootDictionary[1] = itemObject.ball.name;
    }

    // Update is called once per frame
    void Update()
    {

        mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetButton("Fire1"))
        {

            Physics.Raycast(mouseRay, out rayHit);

            if (rayHit.collider.transform.tag == "ball")
            {
                makeItemInvisible("ball");
                putItemInInventory(itemObject.ball.name);
            }

            if (rayHit.collider.transform.tag == "stock")
            {
                makeItemInvisible("stock");
                putItemInInventory(itemObject.stock.name);
            }

            if (rayHit.collider.transform.tag == "saege")
            {
                makeItemInvisible("saege");
                putItemInInventory(itemObject.saege.name);
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
        item.SetActive(false);
    }
}
