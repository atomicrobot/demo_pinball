using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fan : MonoBehaviour {

    public int rotationSpeed;
    public AudioSource audioSource;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed);
	}

    private void OnCollisionEnter(Collision collision)
    {
        audioSource.Play();
    }
}
