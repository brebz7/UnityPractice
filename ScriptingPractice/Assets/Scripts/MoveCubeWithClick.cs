using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCubeWithClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * 500);
    }
}
