using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using myGravity;
using UnityEngine.UI;

public class canon : MonoBehaviour
{
    public GameObject cube;
    public GameObject sphere;
    public Slider force;
    public Slider angle;
    public Dropdown dd;
    float forceV;
    int angleV;
    GameObject obj;
    
    // Start is called before the first frame update
    void Start()
    {
        obj = cube;
        forceV = 0;
        angleV = 0;
        obj.GetComponent<gravity>().speed = new Vector3(0, 25 * forceV * Mathf.Cos((angleV * Mathf.PI) / 180), 25 * forceV * Mathf.Sin((angleV * Mathf.PI) / 180));
    }

    // Update is called once per frame
    void Update()
    {
        obj.GetComponent<gravity>().speed = new Vector3(0, 25 * forceV * Mathf.Sin((angleV * Mathf.PI) /180), 25 * forceV * Mathf.Cos((angleV * Mathf.PI) / 180));

        if (Input.GetButtonDown("Jump"))
        {
            if (collision.num < 10)
            {
                Instantiate(obj, transform.position, Quaternion.identity);
            }
        }
    }

    public void onChange(System.Single newValue)
    {
        forceV = newValue;
    }

    public void angleOnChange(int newValue)
    {
        angleV = newValue;
    }

    public void formOnChange(int val)
    {
        switch (val)
        {
            case 0:
                obj = cube;
                break;
            case 1:
                obj = sphere;
                break;
            default:
                obj = cube;
                break;
        }
    }

}
