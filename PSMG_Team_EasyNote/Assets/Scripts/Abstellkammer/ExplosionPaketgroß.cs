using UnityEngine;
using System.Collections;

public class ExplosionPaketgroß : MonoBehaviour {

    public float radius = 2.0F;
    public float power = 50.0F;
    GameObject Paketgroß;
    // Use this for initialization
    void Start()
    {

        /* rigidbody.isKinematic = false;
           rigidbody.useGravity = true;
           Vector3 explosionPos = transform.position;
           Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
           foreach (Collider hit in colliders)
           {
               if (hit && hit.rigidbody)
                   hit.rigidbody.AddExplosionForce(power, explosionPos, radius, 3.0F);

           }*/

    }

    void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "Paketgroß" && other.tag == "Dynamitgroß")
        {
            //Debug.Log("-----------------------------------!!!!!");
            rigidbody.isKinematic = false;
            rigidbody.useGravity = true;
            explosion();
        }


    }

    void explosion()
    {
        Paketgroß.audio.Play();
        Vector3 explosionPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
        foreach (Collider hit in colliders)
        {
            if (hit && hit.rigidbody)
                hit.rigidbody.AddExplosionForce(power, explosionPos, radius, 3.0F);

        }
    }

    // Update is called once per frame
    void Update()
    {


    }

}
