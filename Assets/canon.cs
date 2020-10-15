using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canon : MonoBehaviour
{
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        GameObject newObj = Instantiate(obj, new Vector3(0f, 0f, 0f), Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
