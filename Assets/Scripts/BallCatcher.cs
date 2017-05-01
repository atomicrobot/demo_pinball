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
        ball.GetComponent<Ball>().resetBall();
        dieAudioSource.Play();
    }
}
