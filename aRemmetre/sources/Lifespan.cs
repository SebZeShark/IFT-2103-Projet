using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifespan : MonoBehaviour
{
    // Start is called before the first frame update
    private float timeToLive = 10.0f;
    canon can;

    private void Awake()
    {
        can = FindObjectOfType<canon>();
    }

    // Update is called once per frame
    void Update()
    {
        timeToLive -= Time.deltaTime;
        if (timeToLive <= 0)
        {
            collision.num--;
            can.OnDestroy();
            Destroy(gameObject);
        }
    }
}
