using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    //public firing firing;
    public int firingNumber;
    public int current_Tank;
    // Start is called before the first frame update
    void Start()
    {
       firingNumber=0;
       current_Tank=0;
    }

    // Update is called once per frame
    void Update()
    {
        //firingNumber=firing.fired;
        // time=firing.time;
        // distance=firing.distance;
        current_Tank=firingNumber%2;
    }
}
