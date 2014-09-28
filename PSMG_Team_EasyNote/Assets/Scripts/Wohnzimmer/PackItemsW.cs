using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class PackItemsW : MonoBehaviour
{


    private Rect inventoryWindow = new Rect(300, 100, 400, 400);
    private bool inventoryWindowShow = false;

    private GameObject objekt;

    ItemClassW itemObjectNew = new ItemClassW();

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

            if (rayHit.collider.transform.tag == "hammer")
            {
                makeItemInvisible("hammer");
                putItemInInventory(itemObjectNew.Hammer.name);
            }

            if (rayHit.collider.transform.tag == "buch")
            {
                makeItemInvisible("buch");
                putItemInInventory(itemObjectNew.Buch.name);
            }

            if (rayHit.collider.transform.tag == "fernbedienung")
            {
                makeItemInvisible("fernbedienung");
                putItemInInventory(itemObjectNew.Fernbedienung.name);
            }

            if (rayHit.collider.transform.tag == "schlüssel")
            {
              
                makeItemInvisible("schlüssel");
                putItemInInventory(itemObjectNew.Schlüssel.name);
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
    
    }


    void makeItemInvisible(string name)
    {

        objekt = GameObject.FindGameObjectWithTag(name);
        objekt.renderer.enabled = false;
        objekt.collider.enabled = false;



    }
}
