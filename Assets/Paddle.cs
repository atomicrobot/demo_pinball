using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    public enum Side
    {
        left, right
    }

    public Side paddleSide = Side.left;
    public int RotationSpeed = 100;
    public float highEndStop = 0.0f;
    public float lowEndStop = 40.0f;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        int rotDir = 1;
        bool keyIsDown = Input.GetKey(paddleSide == Side.left ? KeyCode.LeftShift : KeyCode.RightShift);
        rotDir = keyIsDown ? -1 : 1;

        if ((keyIsDown && transform.localRotation.eulerAngles.y != highEndStop) || (!keyIsDown && transform.localRotation.eulerAngles.y != lowEndStop))
        {
            transform.Rotate(Vector3.up, Time.deltaTime * RotationSpeed * rotDir);
        }

        if (keyIsDown && transform.localRotation.eulerAngles.y > lowEndStop)
        {
            transform.localRotation = Quaternion.Euler(new Vector3(0,highEndStop,0));
        }
        else if (!keyIsDown && transform.localRotation.eulerAngles.y > lowEndStop)
        {
            transform.localRotation = Quaternion.Euler(new Vector3(0, lowEndStop, 0));
        }
    }
}
