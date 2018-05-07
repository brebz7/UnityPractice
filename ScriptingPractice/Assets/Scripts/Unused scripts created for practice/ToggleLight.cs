using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLight : MonoBehaviour {

    public Light m_light;

	// Use this for initialization
	void Start ()
    {
        m_light = gameObject.GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKeyDown(KeyCode.Space))
        {
            m_light.enabled = !m_light.enabled;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            gameObject.SetActive(false);
        }
	}
}
