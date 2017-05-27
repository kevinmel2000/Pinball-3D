using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RFlipperController : MonoBehaviour {

    public GameObject RFlipper;
    public float maxAngularVel = 45;
    public float force = 10;
	// Use this for initialization
	void Start () {
        RFlipper.GetComponent<Rigidbody>().maxAngularVelocity = maxAngularVel;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            RFlipper.GetComponent<Rigidbody>().AddRelativeTorque(new Vector3(0, 0, -force), ForceMode.Impulse);
        }
	}
}
