using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public GameObject field;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(field.transform.position.x, field.transform.position.y + 1, field.transform.position.z);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (Input.GetKey("space"))
        {
            transform.position += -Vector3.forward * Time.deltaTime;
        }
    }
}
