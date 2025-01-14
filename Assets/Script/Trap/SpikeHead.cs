using System;
using UnityEngine;

public class SpikeHead : DamagePlayer
{
    [SerializeField] private float speed;
    [SerializeField] private float range;
    private Vector3 Destination;

    [SerializeField] private float checkDelay;
    private bool Attack;
    private float checkTimer;
    
    [SerializeField] private LayerMask playerLayer;

    private Vector3[] directions = new Vector3[4];

    private void OnEnable()
    {
        Stop();
    }

    private void Update()
    {
        //* When see the player then the spike will move and damage the player
        if (Attack)
        {
            transform.Translate(Destination * Time.deltaTime * speed);
        }
        else
        {
            checkTimer += Time.deltaTime;
            if (checkTimer >= checkDelay)
            {
                checkTimer = 0;
                CheckPlayer();
            }
        }
    }

    private void CheckPlayer()
    {
        CalculateDirection();
        
        for (int i = 0; i < directions.Length; i++)
        {
            //* Show ray in the scene view
            //Debug.DrawRay(transform.position, directions[i], Color.red);
            RaycastHit2D hit = Physics2D.Raycast(transform.position, directions[i], range, playerLayer);
            
            if (hit.collider != null && !Attack)
            {
                Attack = true;
                Destination = directions[i];
                checkTimer = 0;
            }
        }
    }
    
    private void CalculateDirection()
    {
        directions[0] = transform.up * range; //* Up
        directions[1] = -transform.up * range; //* Down
        directions[2] = transform.right * range; //* Right
        directions[3] = -transform.right * range; //* Left
    }

    private void Stop()
    {
        Destination = transform.position;
        Attack = false;
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        base.OnTriggerEnter2D(other);
        Stop();
    }
}
