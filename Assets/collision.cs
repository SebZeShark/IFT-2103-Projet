using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using myGravity;

public class collision : MonoBehaviour
{
    public gravity grav;
    static public int num;

    private float coefficientConcervation = 0.8f;
    private RaycastHit hit;
    private Ray ray;

    // Start is called before the first frame update
    void Awake()
    {
        if (num >= 0)
            num++;
        else
            num = 0;

        Debug.Log(num);
    }

    void Update()
    {
        ray = new Ray(transform.position, grav.speed);
        if(Physics.Raycast(ray, out hit, 0.5f)){
            Vector3 current = grav.speed;
            Vector3 normale = hit.normal;
            Vector3 rebound = coefficientConcervation * Vector3.Reflect(current, normale);
            grav.speed = rebound;
        }
    }

    private void OnCollisionEnter(Collision other)
    {

    }
}
