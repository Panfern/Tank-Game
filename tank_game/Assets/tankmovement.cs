using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankmovement : MonoBehaviour
{
    Rigidbody2D rb;
    
    public playerControl pc;

    public tank_properties tp;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(pc.current_Tank!=tp.tank_number)
        {
            return;
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            rb.velocity=new Vector2(10f,0);

        }
        else if(Input.GetKeyUp(KeyCode.D))
        {
            rb.velocity=new Vector2(0,0);
            
        }
        else if(Input.GetKeyDown(KeyCode.A))
        {
            rb.velocity=new Vector2(-10f,0);

        }
        else if(Input.GetKeyUp(KeyCode.A))
        {
            rb.velocity=new Vector2(0,0);
            
        }
    }
    }

