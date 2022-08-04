using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Vector2 mouseWorldPosition;
    Vector2 direction;

    public float cooldown = 0.5f;
    float timer = 0f;

    public GameObject bullet;
    public Transform shootpoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; 

        mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        direction = (mouseWorldPosition - (Vector2)transform.position).normalized;

        if(Input.GetMouseButton(0) && timer >= cooldown){
            Fire();
            
            timer = 0;
        }
    }

    void Fire()
    {
        Instantiate(bullet, shootpoint.position, shootpoint.rotation);

        
    }
}
