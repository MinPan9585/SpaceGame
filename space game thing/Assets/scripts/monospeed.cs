using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monospeed : MonoBehaviour
{
    public Rigidbody2D body;
    //public float ratio;
    //public Rigidbody2D playerbody;

    private void Awake()
    {
        body.velocity = new Vector2(20, 0);
        
        Physics2D.IgnoreLayerCollision(6, 6);
    }
    private void Update()
    {
        //body.velocity = new Vector2(ratio * playerbody.velocity.x, 0);
    }
}
