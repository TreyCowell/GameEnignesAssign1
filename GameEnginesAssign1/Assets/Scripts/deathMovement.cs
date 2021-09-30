using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathMovement : MonoBehaviour
{
    Rigidbody rigidbody;
    float risingSpeed;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        risingSpeed = 0.35f;
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.velocity = transform.up * risingSpeed;
    }
}
