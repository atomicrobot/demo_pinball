using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class PinballPeg : MonoBehaviour {

    private Material rendererMaterial;
    public AudioSource audioSource;

    [Inject]
    GameSession gameSession;

    // Use this for initialization
    void Start () {
        Physics.defaultContactOffset = 0.1F;
        rendererMaterial = transform.GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update () {
	}

    void OnCollisionEnter(Collision col)
    {
        var directionOfMotion = col.transform.GetComponent<Rigidbody>().velocity.normalized;
        directionOfMotion = -directionOfMotion;
        col.transform.GetComponent<Rigidbody>().AddForce(directionOfMotion * GameSession.PEG_FORCE);

        StartCoroutine("rainbowColors");
        audioSource.Play();

        gameSession.raiseScore(GameSession.PEG_SCORE_VALUE);

    }

    IEnumerator rainbowColors()
    {
        for (float f = 0.0f; f <= 3.0f; f+= Time.deltaTime)
        {
            int tensPlace = ((int)(f * 10)) - ((int)(f));
            int mod = tensPlace % 3;
            Color nextColor = Color.green;
            switch (mod)
            {
                case 0:
                    nextColor = Color.red;
                    break;
                case 1:
                    nextColor = Color.blue;
                    break;
                case 2:
                    nextColor = Color.green;
                    break;
            }

            rendererMaterial.color = nextColor;
            yield return null;
        }

        rendererMaterial.color = new Color(0, 0.5f, 1.0f);
    }
    
}