using UnityEngine;
using System.Collections;

public class ItemClass : MonoBehaviour
{



    static public Texture2D swordIcon;
    static public Texture2D arrowIcon;
    static public Texture2D breadIcon;



    //Items
    public ItemCreatorClass stock = new ItemCreatorClass(0, "Spazierstock", swordIcon, "Ein Spazierstock");
    public ItemCreatorClass saege = new ItemCreatorClass(1, "Säge", arrowIcon, "Eine Säge");
    public ItemCreatorClass stockKurz = new ItemCreatorClass(2, "Kurzer Stock", breadIcon, "Der abgesägte Spazierstock");
    public ItemCreatorClass ball = new ItemCreatorClass(2, "Ball", breadIcon, "Ein kleiner Ball");

    void Start()
    {

    }

    void Update()
    {

    }


    public class ItemCreatorClass
    {

        public int id;
        public string name;
        public Texture2D icon;
        public string description;



        public ItemCreatorClass(int ide, string nam, Texture2D ico, string des)
        {

            id = ide;
            name = nam;
            icon = icon;
            description = des;

        }

    }
}
