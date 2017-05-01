using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCatcher : MonoBehaviour {

    public AudioSource dieAudioSource;
    public GameObject ball;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
        {
            resetBall();
        }
	}

    void OnCollisionEnter(Collision col)
    {
        resetBall();
    }

    void resetBall()
    {
        ball.transform.GetComponent<Rigidbody>().velocity = Vector3.zero;
        ball.transform.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        ball.transform.position = new Vector3(0.0f, 1.0f, -1);

        dieAudioSource.Play();
    }
}
