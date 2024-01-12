using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankBehaviour : MonoBehaviour
{
    Rigidbody2D rb;
    Rigidbody2D muzRb;
    // Start is called before the first frame update
    void Start()
    {
         rb=GetComponent<Rigidbody2D>();
         muzRb=transform.GetChild(1).GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
         //Rotation = 10f;
        if(Input.GetKeyDown(KeyCode.D))
        {
            //rb.AddForce(Vector2.right*40f);
            rb.velocity=new Vector2(10,0);
        }
        else if(Input.GetKeyUp(KeyCode.D))
        {
            rb.velocity=new Vector2(0,0);
        }
        else if(Input.GetKeyDown(KeyCode.A))
        {
             rb.velocity=new Vector2(-10,0);
        }
        else if(Input.GetKeyUp(KeyCode.A))
        {
            rb.velocity=new Vector2(0,0);
        }
        else if(Input.GetKeyUp(KeyCode.W))
        {
            //muzRb.AddTorque(Rotation, ForceMode2D.Impulse);
        }
        }
    }

