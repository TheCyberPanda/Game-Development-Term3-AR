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
}