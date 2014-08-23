using UnityEngine;
using System.Collections;

public class ScheibenDrehen : MonoBehaviour {

    GameObject RAussen, RMitte, RInnen;

  float target = 90.0F;
  float speed = 45.0F;


    //float angle = 0f;



	// Use this for initialization
	void Start () {

        Debug.Log("start");
        RAussen = GameObject.FindGameObjectWithTag("ringAussen");
        RInnen = GameObject.FindGameObjectWithTag("ringInnen");
        RMitte = GameObject.FindGameObjectWithTag("ringMitte");

	}
	
	// Update is called once per frame
	public void Update () {
        RMitteTurn();
	}

    //RMitte.transform.Rotate(0, 0, -90);


    public void RMitteTurn()
    {
        float angle = Mathf.MoveTowardsAngle(RMitte.transform.eulerAngles.z, target, speed * Time.deltaTime);
         RMitte.transform.eulerAngles = new Vector3(0, 180, angle);

        //angle += 90 * Time.deltaTime;
        //RMitte.transform.eulerAngles = new Vector3(0.0, 0.0, angle);
    }

}
