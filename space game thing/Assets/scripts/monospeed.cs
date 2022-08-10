using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monospeed : MonoBehaviour
{
    public Rigidbody2D body;
    public float ratio;
    public Rigidbody2D playerbody;

    private void Awake()
    {
        //body.velocity = new Vector2(playerbody.velocity.x - 15, 0);
    }
    private void Update()
    {
        body.velocity = new Vector2(ratio * playerbody.velocity.x, 0);
    }
}
