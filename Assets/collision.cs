using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using myGravity;

public class collision : MonoBehaviour
{
    public gravity grav;
    static public int num;
    // Start is called before the first frame update
    void Awake()
    {
        if (num >= 0)
            num++;
        else
            num = 0;

        Debug.Log(num);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y <= 0)
        {
            grav.speed.y = -grav.speed.y;
        }
        if(transform.position.z > 100)
        {
            num--;
            Destroy(gameObject);
        }
    }
}
