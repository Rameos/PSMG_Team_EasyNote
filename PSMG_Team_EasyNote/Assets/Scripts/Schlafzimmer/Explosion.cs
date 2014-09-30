using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {

    public float radius = 2.0F;
    public float power = 50.0F;
    GameObject rigid;
    GameObject zb;
    Wecker wecker;
	// Use this for initialization
	void Start () {

        zb = GameObject.FindGameObjectWithTag("ziffernblatt");
        wecker = zb.GetComponent<Wecker>(); 
       
    }

    //Berührt der Spieler mit dem Hammer den Wecker,wird dieser zerstört.
    void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "wecker" || gameObject.tag == "ziffernblatt" && other.tag == "hammer")
        {
            wecker.destroyed = true;
            rigidbody.isKinematic = false;
            rigidbody.useGravity = true;
            explosion();
        }
       
        
    }

    void explosion()
    {
        Vector3 explosionPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
        foreach (Collider hit in colliders)
        {
            if (hit && hit.rigidbody)
                hit.rigidbody.AddExplosionForce(power, explosionPos, radius, 3.0F);

        }
    }
	
	// Update is called once per frame
	void Update () {
       
        
	}

   
}
