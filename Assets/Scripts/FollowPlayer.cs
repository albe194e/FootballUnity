using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject player;

    public readonly Quaternion camRotation = Quaternion.Euler(40, 0,0);
    private readonly Vector3 distance = new Vector3(0,3,-3);

    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = camRotation;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + distance;
    }
}
