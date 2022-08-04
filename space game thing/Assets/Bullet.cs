using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D bulletRigid;
    float speed = 100f;

    void Awake(){
        BulletShoot();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BulletShoot(){
        
        bulletRigid.AddRelativeForce(transform.right * speed);
    }
}
