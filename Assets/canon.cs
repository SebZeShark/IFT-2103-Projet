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
    public Button tirer;
    public Text forceText;
    public Text angleText;
    public Text formeText;
    float forceV;
    int angleV;
    GameObject obj;
    private Vector3 target;
    
    // Start is called before the first frame update
    void Start()
    {
        obj = cube;
        forceV = 0.05f;
        angleV = 0;
        forceText.text = (Mathf.FloorToInt(forceV * 100)).ToString();
        angleText.text = angleV.ToString();
        formeText.text = "Cube";
    }

    // Update is called once per frame
    void Update()
    {
        obj.GetComponent<gravity>().speed = new Vector3(0, 
            25 * forceV * Mathf.Sin((angleV * Mathf.PI) /180),
            25 * forceV * Mathf.Cos((angleV * Mathf.PI) / 180));
    }

    public void onChange(System.Single newValue)
    {
        forceV = newValue;
        forceText.text =  (Mathf.FloorToInt(forceV*100)).ToString();
    }

    public void angleOnChange(System.Single newValue)
    {
        angleV = (int) newValue;
        angleText.text = angleV.ToString();
    }

    public void formOnChange(int val)
    {
        switch (val)
        {
            case 0:
                obj = cube;
                formeText.text = "Cube";
                break;
            case 1:
                obj = sphere;
                formeText.text = "Sphère";
                break;
            default:
                obj = cube;
                formeText.text = "Cube";
                break;
        }

    }

    public void tirerOnClick()
    {
        if (collision.num < 10)
        {
            Instantiate(obj, transform.position + new Vector3(0, 0.5f, 0.5f), Quaternion.identity);
        }
    }
}
