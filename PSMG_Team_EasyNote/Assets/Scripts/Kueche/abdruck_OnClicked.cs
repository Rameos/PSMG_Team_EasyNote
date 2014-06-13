using UnityEngine;
using System.Collections;

public class abdruck_OnClicked : MonoBehaviour {

    //public int[] abdruckStatus = new int[12];
    //public bool katzeStatus = false;
    //private int currentAbdruck;

    //// Use this for initialization
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    //OnMouseDown();
    //}

    //public void abdruck(int currentAbdruck)
    //{
    //    GameObject[] abdruck = GameObject.FindGameObjectsWithTag("abdruck");
    //    if (currentAbdruck == 0)
    //    {
    //        OnMouseDown();
    //    }
    //}

    void OnMouseDown(){
        //float r = Random.Range(0f,1f);
        //float g = Random.Range(0f,1f);
        //float b = Random.Range(0f,1f);
        Color greenColour = new Color(0, 102, 0);
        
        renderer.material.color = greenColour;
        //abdruckStatus[currentAbdruck] = 1; 
    }

}
