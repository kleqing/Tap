using System;
using UnityEngine;

public class Saw_SideAway_X : MonoBehaviour
{
    [Header("Damage")]
    [SerializeField] private float damage;

    [Header("Movement")]
    [SerializeField] private float speed;
    [SerializeField] private float distance;

    private bool isMovingLeft;
    private float leftPoint;
    private float rightPoint;

    private void Awake()
    {
        leftPoint = transform.position.x - distance;
        rightPoint = transform.position.x + distance;
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
        if (isMovingLeft)
        {
            if (transform.position.x > leftPoint)
            {
                transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, transform.position.z);
            }
            else
            {
                isMovingLeft = false;
            }
        }
        else
        {
            if (transform.position.x < rightPoint)
            {
                transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z);
            }
            else
            {
                isMovingLeft = true;
            }
        }
    }
}
