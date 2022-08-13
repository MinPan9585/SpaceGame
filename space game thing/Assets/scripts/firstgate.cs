using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstgate : MonoBehaviour
{
    public GameObject gate;
    public Transform selftransform;
    public GameObject enemy;
    public Transform enemyspawnpoint;
    Vector3 spawnpoint;
    manager manager;
    private int randomint;

    private void Awake()
    {
        selftransform = this.transform;
        manager = FindObjectOfType<manager>();
    }
    
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            //Debug.Log("crossed");
            Instantiate(gate, new Vector3(selftransform.position.x + 96, 0, 0), new Quaternion(0, 0, 0, 0));
            Invoke("enemyspawn", 3);
        }
    }

    private void Update()
    {

        randomint = Random.Range(-4, 4);
        spawnpoint = new Vector3(enemyspawnpoint.position.x, randomint, 0);
    }

    private void enemyspawn()
    {
        Instantiate(enemy, spawnpoint, enemyspawnpoint.rotation);
        if(manager.playerDied == false)
        {
            Invoke("enemyspawn", 2f);
        }
    }
}
