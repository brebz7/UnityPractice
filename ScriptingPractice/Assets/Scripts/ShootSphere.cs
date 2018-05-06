using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootSphere : MonoBehaviour {

    public Rigidbody sphere;
    public Transform sphereSpawn;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody sphereInstance;
            sphereInstance = Instantiate(sphere, sphereSpawn.position, sphereSpawn.rotation) as Rigidbody;
            sphereInstance.AddForce(sphereSpawn.forward * 1200);
        }
	}
}
