using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerpos;
    public Rigidbody2D body;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        body.transform.position = new Vector3(playerpos.position.x, body.transform.position.y, -10);
    }
}
