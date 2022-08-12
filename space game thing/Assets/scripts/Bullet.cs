using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D bulletRigid;
    public float force = 200f;
    public Rigidbody2D playerbody;
    GameObject player;
    void Awake(){
        player = GameObject.Find("PlayerArm");
        playerbody = player.GetComponent<Rigidbody2D>();
        
        bulletRigid.velocity = playerbody.velocity;
        bulletRigid.AddForce(- transform.right * force);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
