using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    // Use this for initialization
    void Start () {
        transform.GetComponent<Rigidbody>().maxAngularVelocity = 100;
	}
	
	// Update is called once per frame
	void Update () {
	}
}
