using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour {

  //public float moveSpeed = 10f;
    public float range;


   
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //if (Input.GetKey(KeyCode.W))
        //    transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        //if (Input.GetKey(KeyCode.S))
        //    transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);

        //if (Input.GetKey(KeyCode.D))
        //    transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

        //if (Input.GetKey(KeyCode.A))
        //    transform.Translate(-Vector3.right * moveSpeed * Time.deltaTime);


        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float xPos = h * range;
        float zPos = v * range;

        transform.Translate(Vector3.right * xPos * Time.deltaTime);
        transform.Translate(Vector3.forward * zPos * Time.deltaTime);
       
	}
}
