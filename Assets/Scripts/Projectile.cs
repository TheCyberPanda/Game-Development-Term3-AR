using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Rigidbody _rb;

    private void Awake()
    {
        _rb = gameObject.GetComponent<Rigidbody>();
        _rb.AddRelativeForce(0, 0, 500);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (!other.gameObject.CompareTag("Enemy")) return;
        
        //Will be reruning object to pool
        Destroy(other.gameObject);
        Destroy(this.gameObject);
    }
}