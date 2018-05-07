using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootSphere : MonoBehaviour {

    public Rigidbody sphere;
    public Rigidbody sphereRed;
    public Rigidbody sphereGreen;
    public Rigidbody sphereBlue;
    public Transform sphereSpawn;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1") && gameObject.GetComponent<Renderer>().material.color == Color.red)
        {
            Shoot(sphereRed);
        }

        else if (Input.GetButtonDown("Fire1") && gameObject.GetComponent<Renderer>().material.color == Color.green)
        {
            Shoot(sphereGreen);
        }

        else if (Input.GetButtonDown("Fire1") && gameObject.GetComponent<Renderer>().material.color == Color.blue)
        {
            Shoot(sphereBlue);
        }

        else if (Input.GetButtonDown("Fire1"))
        {
            Shoot(sphere);
        }
    }

    void Shoot(Rigidbody sphereType)
    {
        Rigidbody sphereInstance;
        sphereInstance = Instantiate(sphereType, sphereSpawn.position, sphereSpawn.rotation) as Rigidbody;
        sphereInstance.AddForce(sphereSpawn.forward * 1200);
    }
}
