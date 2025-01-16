using System;
using UnityEngine;

public class Saw_SideAway_Y : MonoBehaviour
{
    [Header("Damage")]
    [SerializeField] private float damage;
    
    [Header("Movement")]
    [SerializeField] private float speed;
    [SerializeField] private float distance;
    
    private bool isMovingDown;
    private float downPoint;
    private float upPoint;

    private void Awake()
    {
        downPoint = transform.position.y - distance;
        upPoint = transform.position.y + distance;
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<Health>().TakeDamage(damage);
        }
    }

    private void Update()
    {
        if (isMovingDown)
        {
            if (transform.position.y > downPoint)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - speed * Time.deltaTime, transform.position.z);
            }
            else
            {
                isMovingDown = false;
            }
        }
        else
        {
            if (transform.position.y < upPoint)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + speed * Time.deltaTime, transform.position.z);
            }
            else
            {
                isMovingDown = true;
            }
        }
    }
}
