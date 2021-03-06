﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

    [Range(1, 10)]
    public float jumpVelocity;
    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;

    private Rigidbody rb;
    private bool isGrounded = true;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            GetComponent<Rigidbody>().velocity = Vector3.up * jumpVelocity;
        }
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
        else if (rb.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ground")
            isGrounded = true;
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Ground")
            isGrounded = false;
    }
}
