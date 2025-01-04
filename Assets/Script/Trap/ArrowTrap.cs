using System;
using UnityEngine;

public class ArrowTrap : MonoBehaviour
{
    [SerializeField] private float attackCooldon;
    [SerializeField] private GameObject[] Arrow;
    [SerializeField] private Transform firePoint;
    private float CooldownTimer;
    private void Attack()
    {
        CooldownTimer = 0;
        
        Arrow[FindArrow()].transform.position = firePoint.position;
        Arrow[FindArrow()].GetComponent<ArrowProjectile>().ActiveProjectile(Mathf.Sign(transform.localScale.x));
    }

    private int FindArrow()
    {
        for (int i = 0; i < Arrow.Length; i++)
        {
            if (Arrow[i].activeInHierarchy)
            {
                return i;
            }
        }
        return 0;
    }
    
    private void Update()
    {
        CooldownTimer += Time.deltaTime;
        if (CooldownTimer >= attackCooldon)
        {
            Attack();
        }
    }
}
