﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    private float timeToLive = 10.0f;

    // Update is called once per frame
    void Update()
    {
        timeToLive -= Time.deltaTime;
        if (timeToLive <= 0)
        {
            Destroy(gameObject);
        }
    }
}