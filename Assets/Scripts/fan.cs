using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fan : MonoBehaviour {

    public int rotationSpeed;
    public AudioSource audioSource;

	void Awake() {

	}

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed);
	}

	void FixedUpdate() {
		//Physics updates
	}

    private void OnCollisionEnter(Collision collision)
    {
        audioSource.Play();
    }
}
