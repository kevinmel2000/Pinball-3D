using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityMod : MonoBehaviour {

    public GameObject Pinball;
    public float forceIncrease = 1;
    public float gravityMultiplier = 3;

	// Use this for initialization
	void Start () {
        Rigidbody Pinball = GetComponent < Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Pinball.GetComponent<Rigidbody>().AddForce(gravityMultiplier * Physics.gravity + new Vector3(0, 0, -forceIncrease));
	}
}
