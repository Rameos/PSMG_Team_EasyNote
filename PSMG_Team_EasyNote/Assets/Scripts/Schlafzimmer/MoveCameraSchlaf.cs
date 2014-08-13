using UnityEngine;
using System.Collections;

public class MoveCameraSchlaf : MonoBehaviour
{
   


    void start()
    {
        
        GameObject kastenDoor = GameObject.FindGameObjectWithTag("kastenDoor");
        openKasten oK = kastenDoor.GetComponent<openKasten>();
        oK.test = 10;
    }

    void Update()
    {
        GameObject bild = GameObject.FindGameObjectWithTag("bild");
        BildAnim bildAnim = bild.GetComponent<BildAnim>(); 

        if (Input.GetKey("1"))
        {
            Debug.Log("input");
            gameObject.transform.rotation = new Quaternion(-0.0001444171f, -0.9994187f, 0.03382654f, -0.004266861f);
            gameObject.transform.position = new Vector3(1.02739f, 3.135389f, -6.216825f);
        }
       

        if (Input.GetKey("2"))
        {
            gameObject.transform.rotation = new Quaternion(-0.0001444171f, -0.9994187f, 0.03382654f, -0.004266861f);
            gameObject.transform.position = new Vector3( -0.7302749f, 1.362143f, -11.7172f);
           
        }
        if (Input.GetKey("3"))
        {
            gameObject.transform.rotation = new Quaternion(-0.0001444171f, -0.9994187f, 0.03382654f, -0.004266861f);
            gameObject.transform.position = new Vector3(2.386247f, 1.362143f, -11.69059f);

        }
        if (Input.GetKey("4"))
        {
            gameObject.transform.rotation = new Quaternion(-0.0001444171f, -0.9994187f, 0.03382654f, -0.004266861f);
            gameObject.transform.position = new Vector3(0.7115088f, 3.726096f, -11.44798f);

        }
        if (Input.GetKey("5"))
        {

            gameObject.transform.rotation = new Quaternion(0.08342661f, -0.7029205f, 0.08935602f, 0.7006842f);
            gameObject.transform.position = new Vector3(-1.21845f, 2.351019f, -10.10403f);

        }
         if (Input.GetKey("6"))
        {
            if (bildAnim.PicOpen == true) { 
            gameObject.transform.rotation = new Quaternion(-0.000144423f, -0.99913f, 0.04137637f, -0.005221334f);
            gameObject.transform.position = new Vector3(3.786846f, 3.433309f, -11.93143f);
         }
        }


    }
}


/* alte rot koord:
 -0.0001444171
-0.9994187
0.03382654
-0.004266861
*/