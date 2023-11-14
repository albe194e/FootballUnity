using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{


    public float movementSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.position += Vector3.forward * Time.deltaTime * movementSpeed;
        }

        if (Input.GetKey("s"))
        {
            transform.position += Vector3.back * Time.deltaTime * movementSpeed;
        }
        if (Input.GetKey("a"))
        {
            transform.position -= Vector3.right * Time.deltaTime * movementSpeed;
        }
        if (Input.GetKey("d"))
        {
            transform.position += Vector3.right * Time.deltaTime * movementSpeed;
        }
    }
}
