using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class ScoreBoard : MonoBehaviour {

    [Inject]
    GameSession gameSession;

    public Text scoreTxt;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        scoreTxt.GetComponent<Text>().text = gameSession.score.ToString();
	}
}
