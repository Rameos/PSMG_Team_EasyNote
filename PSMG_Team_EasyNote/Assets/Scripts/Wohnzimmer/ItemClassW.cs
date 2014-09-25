using UnityEngine;
using System.Collections;

public class ItemClassW : MonoBehaviour
{



    static public Texture2D swordIcon1;
    static public Texture2D arrowIcon;
    static public Texture2D breadIcon;



    //Items
  
    public ItemCreatorClassW Fernbedienung = new ItemCreatorClassW(0, "Fernbedienung", swordIcon1, "Eine Fernbedienung");
    public ItemCreatorClassW Hammer = new ItemCreatorClassW(0, "Hammer", swordIcon1, "Ein Hammer");
    public ItemCreatorClassW Schlüssel = new ItemCreatorClassW(0, "Schlüssel", swordIcon1, "Ein Schlüssel");
    public ItemCreatorClassW Buch = new ItemCreatorClassW(0, "Buch", swordIcon1, "Ein Buch");


    void Start()
    {

    }

    void Update()
    {

    }


    public class ItemCreatorClassW
    {

        public int id;
        public string name;
        public Texture2D icon;
        public string description;



        public ItemCreatorClassW(int ide, string nam, Texture2D ico, string des)
        {

            id = ide;
            name = nam;
            icon = ico;
            description = des;

        }

    }
}
