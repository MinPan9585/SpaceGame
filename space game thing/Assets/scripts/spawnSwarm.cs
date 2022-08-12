using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnSwarm : MonoBehaviour
{

    public GameObject gate;
    public GameObject[] presets;
    public Transform selftransform;

    private int randomint;

    private void Awake()
    {
        selftransform = this.transform;
        randomint = Random.Range(0, presets.Length);
        Instantiate(presets[randomint], selftransform.position, selftransform.rotation);
        Debug.Log(randomint);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            //Debug.Log("crossed");
            Instantiate(gate, new Vector3(selftransform.position.x + 128, 0, 0), new Quaternion (0,0,0,0));

        }
    }
}
