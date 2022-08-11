using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallEnemy : MonoBehaviour
{
    private float enemySpeed = 0.5f;
    private Vector2 enemyDirection;
    public Rigidbody2D rb2d;
    public GameObject player;

    void FixedUpdate()
    {
        enemyDirection = player.transform.position - transform.position;
        //enemyDirection.normalized
        rb2d.MovePosition((Vector2)transform.position + enemySpeed * enemyDirection * Time.fixedDeltaTime);
    }
}
