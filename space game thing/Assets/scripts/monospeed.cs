using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monospeed : MonoBehaviour
{
    public Rigidbody2D body;
    //public float ratio;
    //public Rigidbody2D playerbody;
    bool hasStopped;
    manager manager;
    public GameObject player;
    private void Awake()
    {
        body.velocity = new Vector2(20, 0);

        manager = FindObjectOfType<manager>();

        hasStopped = false;

        Physics2D.IgnoreLayerCollision(6, 6);

        player = GameObject.Find("PlayerArm");
    }
    private void Update()
    {
        //body.velocity = new Vector2(ratio * playerbody.velocity.x, 0);
        if(hasStopped == false && manager.playerDied == true)
        {
            Invoke("stop", 1.5f);
            hasStopped = true;
        }

        if(player.transform.position.x - body.transform.position.x > 36)
        {
            Destroy(gameObject);
        }
    }

    private void stop()
    {
        body.velocity = new Vector2(0, 0);
    }
}
