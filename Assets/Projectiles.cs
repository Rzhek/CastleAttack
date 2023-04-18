using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Projectiles : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float forceAmount = 15.0f;
    public GameObject explosionPrefab;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        Vector3 forceDirection = transform.forward;

        rigidbody.AddForce(forceDirection * forceAmount, ForceMode.VelocityChange);
    }

    void OnCollisionEnter(Collision other)
    {   
        if (other.gameObject.CompareTag("Castle"))
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
