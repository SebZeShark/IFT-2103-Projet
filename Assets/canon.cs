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
    public Dropdown dd;
    GameObject obj;
    private Vector3 target;
    
    // Start is called before the first frame update
    void Start()
    {
        obj = cube;
        obj.GetComponent<gravity>().speed = new Vector3(0, 25 * 0, 25 * 0);
        target = new Vector3(0, 15, 15);
    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetButtonDown("Jump"))
        {
            if (collision.num < 10)
            {
                Instantiate(obj, transform.position, Quaternion.identity);
                obj.GetComponent<gravity>().speed = target;
            }
        }
    }

    public void onChange(System.Single newValue)
    {
        target = new Vector3(0, 25 * newValue, 25 * newValue);
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
