using UnityEngine;
using System.Collections;

public class ItemClass : MonoBehaviour
{



    static public Texture2D swordIcon1;
    static public Texture2D arrowIcon;
    static public Texture2D breadIcon;



    //Items
    public ItemCreatorClassW Batterie = new ItemCreatorClassW(0, "Batterien", swordIcon1, "Mehrere Batterien");
    public ItemCreatorClassW Fernbedienung = new ItemCreatorClassW(0, "Fernbedienung", swordIcon1, "Eine Fernbedienung");
    public ItemCreatorClassW Hammer = new ItemCreatorClassW(0, "Hammer", swordIcon1, "Ein Hammer");
    public ItemCreatorClassW Schlüssel = new ItemCreatorClassW(0, "Schlüssel", swordIcon1, "Ein Schlüssel");
   // public ItemCreatorClass Säge = new ItemCreatorClass(1, "Säge", arrowIcon, "Eine Säge");
    //public ItemCreatorClass stockKurz = new ItemCreatorClass(2, "Kurzer Stock", breadIcon, "Der abgesägte Spazierstock");
    //public ItemCreatorClass Ball = new ItemCreatorClass(3, "Ball", breadIcon, "Ein kleiner Ball");


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
