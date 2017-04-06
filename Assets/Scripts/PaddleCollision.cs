using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Physics.defaultContactOffset = 0.1F;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Collision");
        Rigidbody colRB = col.transform.GetComponent<Rigidbody>();
        colRB.AddForce(transform.up * colRB.velocity.magnitude*10);
        //col.transform.GetComponent<Rigidbody>().angularVelocity
    }
}
