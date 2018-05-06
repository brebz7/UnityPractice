using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour {

    public float movementSpeed;
    public float turnRateSpeed;

    private float movementInputValue;
    private float turnRateInputValue;
    private Rigidbody m_rigidbody;

    // Use this for initialization
    void Start ()
    {
        m_rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        movementInputValue = Input.GetAxis("Vertical");
        turnRateInputValue = Input.GetAxis("Horizontal");   
	}

    void FixedUpdate ()
    {
        Vector3 movement = transform.forward * movementInputValue * 10 * Time.deltaTime;
        m_rigidbody.MovePosition(m_rigidbody.position + movement);

        float turn = turnRateInputValue * turnRateSpeed * Time.deltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
        m_rigidbody.MoveRotation(m_rigidbody.rotation * turnRotation);
    }
}