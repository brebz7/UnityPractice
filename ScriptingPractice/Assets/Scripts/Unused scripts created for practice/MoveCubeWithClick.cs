using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCubeWithClick : MonoBehaviour {

    public ParticleSystem psystem;

    void OnMouseDown()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * 500);
        psystem.Play();
    }
}
