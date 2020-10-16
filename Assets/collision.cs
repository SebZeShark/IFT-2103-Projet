using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using myGravity;

public class collision : MonoBehaviour
{
    public gravity grav;
    static public int num;

    private float coefficientConcervation = 0.8f;

    // Start is called before the first frame update
    void Awake()
    {
        if (num >= 0)
            num++;
        else
            num = 0;

        Debug.Log(num);
    }

    private void OnCollisionEnter(Collision other)
    {
        Vector3 current = grav.speed;
        Vector3 normale = other.contacts[0].normal;
        Vector3 rebound = coefficientConcervation * Vector3.Reflect(current, normale);
        grav.speed = rebound;
    }
}
