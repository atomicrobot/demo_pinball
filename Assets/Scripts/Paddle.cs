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
    public float range = 50.0f;
    public float defaultPos = 40.0f;

    int ccw;

    // Use this for initialization
    void Start () {
        ccw = (paddleSide == Side.left ? 1 : -1);//does paddle move counter clockwise?
    }

    // Update is called once per frame
    void Update() {
        bool keyIsDown = Input.GetKey(paddleSide == Side.left ? KeyCode.LeftShift : KeyCode.RightShift);
        int rotDir = keyIsDown ? -1 : 1;
        rotDir = rotDir * ccw;
        float highPos = (defaultPos - (ccw * range));
        if (highPos < 0.0f)
        {
            highPos = 360.0f + highPos;
        }

        if ((keyIsDown && transform.localRotation.eulerAngles.y != highPos) || (!keyIsDown && transform.localRotation.eulerAngles.y != defaultPos))
        {
            transform.Rotate(Vector3.up, Time.deltaTime * RotationSpeed * rotDir);
        }

        if (ccw == 1)
        {
            if (keyIsDown && transform.localRotation.eulerAngles.y > defaultPos && transform.localRotation.eulerAngles.y < highPos)
            {
                transform.localRotation = Quaternion.Euler(new Vector3(transform.localRotation.x, highPos, transform.localRotation.z));
            }
            else if (!keyIsDown && transform.localRotation.eulerAngles.y > defaultPos && transform.localRotation.eulerAngles.y < highPos)
            {
                transform.localRotation = Quaternion.Euler(new Vector3(transform.localRotation.x, defaultPos, transform.localRotation.z));
            }
        }
        else if (ccw == -1)
        {
            if (keyIsDown && transform.localRotation.eulerAngles.y > highPos)
            {
                transform.localRotation = Quaternion.Euler(new Vector3(transform.localRotation.x, highPos, transform.localRotation.z));
            }
            else if (!keyIsDown && transform.localRotation.eulerAngles.y < defaultPos)
            {
                transform.localRotation = Quaternion.Euler(new Vector3(transform.localRotation.x, defaultPos, transform.localRotation.z));
            }
        }
        
    }
}
