using UnityEngine;
using System.Collections;

public class MoveCameraKeller : MonoBehaviour {

    GameObject cam = GameObject.FindGameObjectWithTag("MainCamera");
    
	// Use this for initialization
    void start()
    {
        
        GameObject kastenDoor = GameObject.FindGameObjectWithTag("kastenDoor");
        openKasten oK = kastenDoor.GetComponent<openKasten>();
       

        
    }

    //Durch Betätigen der Tasten wechselt die Kamera auf die gewünschte Position
    void Update()
    {
        if (Input.GetKey("1"))
        {
            
            gameObject.transform.position = new Vector3(-2.718926f, 2.183627f, 0.1953902f);
        }
        if (Input.GetKey("2"))
        {
            gameObject.transform.position = new Vector3(-0.04106632f, 1.589996f, -1.078887f);
           
        }

    
    }

   
}
