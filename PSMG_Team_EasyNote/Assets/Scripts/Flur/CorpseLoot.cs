using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class CorpseLoot : MonoBehaviour {


    private Rect inventoryWindowRect = new Rect(300, 100, 400, 400);
    private bool inventoryWindowShow = false;

    private Dictionary<int, string> lootDictionary = new Dictionary<int, string>()
    {
        {0, string.Empty},
         {1, string.Empty},
          {2, string.Empty},
           {3, string.Empty},
           {4, string.Empty},
         {5, string.Empty},
    };

    ItemClass itemObject = new ItemClass();

    private Ray mouseRay;
    private RaycastHit rayHit;

	// Use this for initialization
	void Start () {

	//display dictionary
        lootDictionary[0] = itemObject.saege.name;
        lootDictionary[1] = itemObject.ball.name;
	}
	
	// Update is called once per frame
	void Update () {

        mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Input.GetButton ("Fire1"))
        {
            Physics.Raycast(mouseRay, out rayHit);
            if (rayHit.collider.transform.tag == "LootableCorpse")
            {
                inventoryWindowShow = true;

            }
        }
	
        //Close window

        if (Input.GetKeyDown ("l"))
        {
            inventoryWindowShow = false;
        }
	}

    void OnGUI()
    {
        if (inventoryWindowShow)
        {
            inventoryWindowRect = GUI.Window(0, inventoryWindowRect, inventoryWindowMethod, "Corpse");
        }
    }

    
    void inventoryWindowMethod(int windowId)
    {

        GUILayout.BeginArea(new Rect(5, 50, 395, 400));

        GUILayout.BeginHorizontal();

        if(GUILayout.Button (lootDictionary[0], GUILayout.Height (50)))
        {
            if (lootDictionary[0] != string.Empty)
            {
                InventoryGUI.inventoryNameDictionary[0] = lootDictionary[0];
                lootDictionary[0] = string.Empty;
            }
        }

        if (GUILayout.Button(lootDictionary[1], GUILayout.Height(50)))
        {
            if (lootDictionary[1] != string.Empty)
            {
                InventoryGUI.inventoryNameDictionary[1] = lootDictionary[1];
                lootDictionary[1] = string.Empty;
            }
        }

        if (GUILayout.Button(lootDictionary[2], GUILayout.Height(50)))
        {
            if (lootDictionary[2] != string.Empty)
            {
                InventoryGUI.inventoryNameDictionary[2] = lootDictionary[2];
                lootDictionary[2] = string.Empty;
            }
        }
   

        GUILayout.EndArea();

    }
}
