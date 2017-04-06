using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleCollision : MonoBehaviour {

    Rigidbody RB;
    public Paddle paddleGameObject;

	// Use this for initialization
	void Start () {
        Physics.defaultContactOffset = 0.1F;
        RB = transform.GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision col)
    {
        print(RB.angularVelocity.magnitude);
        Rigidbody colRB = col.transform.GetComponent<Rigidbody>();
        if (paddleGameObject.isKeyDown() && paddleGameObject.hasNotReachedRotaionBounds())
            colRB.AddForce(transform.up * 10);
        //col.transform.GetComponent<Rigidbody>().angularVelocity
    }
}
