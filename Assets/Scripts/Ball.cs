using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    private Vector3 startingPosition;

    // Use this for initialization
    void Start () {
        transform.GetComponent<Rigidbody>().maxAngularVelocity = 100;
        startingPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void resetBall()
    {
        transform.GetComponent<Rigidbody>().velocity = Vector3.zero;
        transform.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        transform.position = startingPosition;
    }
}
