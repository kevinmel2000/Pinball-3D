using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinballSpawner : MonoBehaviour {

    public GameObject Pinball;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Pinball, gameObject.transform.localPosition, Quaternion.identity);
        }
    }
}
