using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLight : MonoBehaviour {

    public Light light;

	// Use this for initialization
	void Start ()
    {
        light = gameObject.GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKeyDown(KeyCode.Space))
        {
            light.enabled = !light.enabled;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            gameObject.SetActive(false);
        }
	}
}
