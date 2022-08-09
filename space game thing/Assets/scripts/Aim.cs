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

    public float cooldown = 0.5f;
    float timer = 0f;
    private void Start()
    {
        m_transform = this.transform;
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
        LAMouse();
        
        timer += Time.deltaTime;

        if (Input.GetMouseButton(0) && timer >= cooldown)
        {
            Fire();

            timer = 0;
        }
    }

    void Fire()
    {
        Instantiate(bullet, shootpoint.transform.position, shootpoint.transform.rotation);
        Instantiate(flash, shootpoint.transform);
        body.AddForce(transform.right * recoilforce);
    }
}
