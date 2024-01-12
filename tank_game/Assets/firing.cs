using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firing : MonoBehaviour
{
    Rigidbody2D projectile;
   // Vector2 magnitude;
    public float x;
    public float y;
    public bool flag;
    public int fired;
    public double time;
    public double distance;
    // Start is called before the first frame update
    void Start()
    {
        time=0.0;
        distance=0.0;
        projectile=GetComponent<Rigidbody2D>();
       // magnitude=Vector2(10,10);
        x=45f;
        y=45f;
        fired=0;
    }

    // Update is called once per frame
    void Update()
{
    time=2*(y/9.81);
    distance=x*time;
    Vector2 force = new Vector2(x, y);
    if(Input.GetKey(KeyCode.Mouse0) && !flag)
    {
        if(fired==0)
        projectile.AddForce(force,ForceMode2D.Impulse);
        else
        StartCoroutine(fireDelay(force));
        fired++;
        flag=true;
    }
    if(flag && !Input.GetKey(KeyCode.Mouse0))
    {
        flag=false;
        
    }
}
    //projectile.transform.Rotate(0,0,-30f*Time.deltaTime);
   IEnumerator fireDelay(Vector2 force)
   {
    
    //if(fired!=0)
    yield return new WaitForSeconds((float)time);
    projectile.AddForce(force,ForceMode2D.Impulse);
   }
    
}

