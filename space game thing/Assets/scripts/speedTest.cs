using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedTest : MonoBehaviour
{
    public float recoilforce;
    public float CD;
    public Rigidbody2D body;
    private float timer = 0f;
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= CD)
        {
            fire();
            //Debug.Log("timer is now larger than cd");

            timer = 0;
        }
    }

    private void fire()
    {
        body.AddForce(transform.right * recoilforce); 
    }
}
