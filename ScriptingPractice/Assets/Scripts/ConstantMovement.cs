using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantMovement : MonoBehaviour {

    public Rigidbody rb;
    public float forwardForce;

    void FixedUpdate()
    {
        //rb.AddForce(0, 0, forwardForce * Time.deltaTime); 
        rb.MovePosition(rb.position + Vector3.forward * forwardForce * Time.deltaTime);
    }
}
