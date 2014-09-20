using UnityEngine;
using System.Collections;

public class SchalterClicked : MonoBehaviour {


    public bool schalterAn = false;
    GameObject tv;
    public Texture tvOff;
    public Texture tvOn;
	// Use this for initialization
	void Start () {
        tv = GameObject.FindGameObjectWithTag("TV");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        if (schalterAn == false)
        {         
            transform.localEulerAngles = new Vector3(294.0708f, 89.62922f, -1.67462e-05f);
            Color redShine = Color.red;
            renderer.material.color = redShine;
            tv.renderer.material.mainTexture = tvOn;
           
            schalterAn = true;
            

        }

        else
        {
            
            transform.localEulerAngles = new Vector3(284.7442f, 269.6292f, 180f);
            Color dark =  Color.black;
            renderer.material.color = dark;
            tv.renderer.material.mainTexture = tvOff;
            schalterAn = false;
        }
        }
       
}
