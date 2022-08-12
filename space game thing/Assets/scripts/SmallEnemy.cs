using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallEnemy : MonoBehaviour
{
    private float speed;
    private Vector2 enemyDirection;
    public Rigidbody2D rb2d;
    public Rigidbody2D playerbody;
    GameObject player;

    private void Awake()
    {
        //speed = 40;
        player = player = GameObject.Find("playerbody");
        playerbody = player.GetComponent<Rigidbody2D>();
        Physics2D.IgnoreLayerCollision(3, 3);
    }

    void FixedUpdate()
    {

        speed = playerbody.velocity.x + 5;
        enemyDirection = playerbody.transform.position - transform.position;
        
        rb2d.MovePosition((Vector2)transform.position + speed * enemyDirection.normalized * Time.fixedDeltaTime);
    }

    private void Update()
    {
        if(playerbody.position.x - rb2d.position.x > 36)
        {
            Destroy(gameObject);
            Debug.Log("die");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "bullet")
        {
            Destroy(gameObject);
            Debug.Log("hit");

        }
    }
}
