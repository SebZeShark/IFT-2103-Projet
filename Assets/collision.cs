using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using myGravity;

public class collision : MonoBehaviour
{
    public gravity grav;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(grav.speed.y < -10)
        {
            grav.speed.y = -grav.speed.y;
        }
        
    }
}
