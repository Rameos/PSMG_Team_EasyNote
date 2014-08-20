using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {

    public float radius = 2.0F;
    public float power = 50.0F;
    GameObject rigid;
	// Use this for initialization
	void Start () {
        rigidbody.isKinematic = false;
        rigidbody.useGravity = true;
        Debug.Log("+++++++++++++++++++++++++++++: " + rigidbody);
        Vector3 explosionPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
        foreach (Collider hit in colliders)
        {
            if (hit && hit.rigidbody)
                hit.rigidbody.AddExplosionForce(power, explosionPos, radius, 3.0F);

        }
    }

    void OnMouseDown()
    {

        
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
