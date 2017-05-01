using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleCollision : MonoBehaviour {

    public Paddle paddleGameObject;
    public AudioSource audioSource;

	// Use this for initialization
	void Start () {
        Physics.defaultContactOffset = 0.1F;
    }
	
	// Update is called once per frame
	void Update () {
		
	}



    void OnCollisionEnter(Collision col)
    {
        if (paddleGameObject.isKeyDown() && paddleGameObject.hasNotReachedRotaionBounds())
        {
            col.transform.GetComponent<Rigidbody>().AddForce(transform.up * GameSession.PADDLE_FORCE);
            audioSource.Play();
        }
    }
}
