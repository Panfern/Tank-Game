using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newAim : MonoBehaviour
{
    Rigidbody2D muzzle;
    float aimspeed;

     public playerControl pc;

    public tank_properties tp;
    // Start is called before the first frame update
    void Start()
    {
        aimspeed=10f;
        muzzle=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(pc.current_Tank!=tp.tank_number)
        {
            return;
        }

        if(Input.GetKey(KeyCode.W))
        {
            muzzle.transform.Rotate(0,0,aimspeed*Time.deltaTime);
            
        }
    }
}
