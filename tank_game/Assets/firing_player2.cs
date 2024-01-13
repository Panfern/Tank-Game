using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firing_player2 : MonoBehaviour
{
    Rigidbody2D projectile;
   // Vector2 magnitude;
    public float x;
    public float y;
    public bool flag;
    public int fired;
    public double time;
    public double distance;
    public playerControl pc;
    public int n;
    // Start is called before the first frame update
    void Start()
    {
        time=0.0;
        distance=0.0;
        projectile=GetComponent<Rigidbody2D>();
       // magnitude=Vector2(10,10);
        x=0f;
        y=45f;
        fired=0;
        flag= true;
    }

    // Update is called once per frame
    void Update()
{
   
    if(pc.firingNumber%2!=0)
    {
    time=2*(y/9.81);
    distance=x*time;
    Vector2 force = new Vector2(x, y);
    if(Input.GetKey(KeyCode.Mouse0) && !flag)
    {
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

