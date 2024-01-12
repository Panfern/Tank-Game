using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aim : MonoBehaviour
{
    Rigidbody2D muzrb;
    float angVel=0f;
    // Start is called before the first frame update
    void Start()
    {
        muzrb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        muzrb.angularVelocity = angVel;
        if(Input.GetKeyDown(KeyCode.W))
        {
            angVel=150f;
        }
        else if(Input.GetKeyUp(KeyCode.W))
        {
            angVel=0f;
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            angVel=-150f;
        }
        else if(Input.GetKeyUp(KeyCode.S))
        {
            angVel=0f;
        }

    }
}
