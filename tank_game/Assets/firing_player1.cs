using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class firing_player1 : MonoBehaviour
{
    Rigidbody2D projectile;
   // Vector2 magnitude;
    public float x;
    public float y;
    float velocity;
    public bool flag;
    public int fired;
    public playerControl pc;
    public int n;
    public tank_properties tp;
    double currentAngle;
    // Start is called before the first frame update
    void Start()
    {
        projectile=GetComponent<Rigidbody2D>();
        velocity=100;
        x=0;
        y=0;
        fired=0;
        currentAngle=0;
    }

    // Update is called once per frame
    void Update()
{
   
   if(pc.current_Tank!=tp.tank_number)
        {
            return;
        }
    currentAngle=tp.zAxis>180?(360-tp.zAxis):(-1)*tp.zAxis;
    
    x=(float)(velocity*Math.Sin(currentAngle*Math.PI/180));
    y=(float)(velocity*Math.Cos(currentAngle*Math.PI/180));
    
    if(pc.firingNumber%2==0)
    {
    Vector2 force = new Vector2(x, y);
    if(Input.GetKey(KeyCode.Mouse0) && !flag)
    {
        Debug.Log(x);
        Debug.Log(y);
        Debug.Log(force);
        Debug.Log(currentAngle);
       
        projectile.AddForce(force,ForceMode2D.Impulse);
        pc.firingNumber++;
        flag=true;
    }
    if(flag && !Input.GetKey(KeyCode.Mouse0))
    {
        flag=false;
        
    }
    }
}   
}

