using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using myGravity;

public class canon : MonoBehaviour
{
    gravity grav;
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(obj, new Vector3(0f, 0f, 0f), Quaternion.identity);

        grav = obj.GetComponent<gravity>();

        grav.speed = new Vector3(0, 15, 15);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (collision.num < 1)
            {
                Instantiate(obj, new Vector3(0f, 0f, 0f), Quaternion.identity);

                obj.GetComponent<gravity>().speed = new Vector3(0, 15, 15);
            }
        }
        
    }
}
