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
    private Vector3 target;
    
    // Start is called before the first frame update
    void Start()
    {
        obj = cube;
<<<<<<< HEAD
        forceV = 0;
        angleV = 0;
        obj.GetComponent<gravity>().speed = new Vector3(0, 25 * forceV * Mathf.Cos((angleV * Mathf.PI) / 180), 25 * forceV * Mathf.Sin((angleV * Mathf.PI) / 180));
=======
        obj.GetComponent<gravity>().speed = new Vector3(0, 25 * 0, 25 * 0);
        target = new Vector3(0, 15, 15);
>>>>>>> 825926fa6b96475d16f0068d6301894e46521afb
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
<<<<<<< HEAD
=======
                obj.GetComponent<gravity>().speed = target;
>>>>>>> 825926fa6b96475d16f0068d6301894e46521afb
            }
        }
    }

    public void onChange(System.Single newValue)
    {
<<<<<<< HEAD
        forceV = newValue;
    }

    public void angleOnChange(int newValue)
    {
        angleV = newValue;
=======
        target = new Vector3(0, 25 * newValue, 25 * newValue);
>>>>>>> 825926fa6b96475d16f0068d6301894e46521afb
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
