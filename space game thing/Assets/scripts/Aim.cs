using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    private Transform m_transform;
    public Rigidbody2D body;
    public GameObject shootpoint;
    public GameObject bullet;
    public float recoilforce;
    public GameObject flash;
    manager manager;
    public BoxCollider2D bodycollider;

    public float cooldown = 0.5f;
    float timer = 0f;
    private void Start()
    {
        m_transform = this.transform;
        manager = FindObjectOfType<manager>();
    }

    private void LAMouse()
    {
        
            Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - m_transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            Quaternion rotation = Quaternion.AngleAxis(angle - 180, Vector3.forward);
            m_transform.rotation = rotation;
        
    }

    private void Update()
    {
        if (manager.playerDied == false)
        {
            LAMouse();
        }
        
        timer += Time.deltaTime;

        if (Input.GetMouseButton(0) && timer >= cooldown && manager.playerDied == false)
        {
            Fire();

            timer = 0;
        }

        if(manager.playerDied == true)
        {
            Invoke("fall", 1.5f);
        }
    }

    void fall()
    {
        body.gravityScale = 2.5f;
        bodycollider.enabled = false;
    }
    void Fire()
    {
        Instantiate(bullet, shootpoint.transform.position, shootpoint.transform.rotation);
        Instantiate(flash, shootpoint.transform);
        body.AddForce(transform.right * recoilforce);
        manager.gameStarted = true;
    }
}
