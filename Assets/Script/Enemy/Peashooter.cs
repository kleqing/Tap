using System;
using UnityEngine;

public class Peashooter : MonoBehaviour
{
    [Header("Attack")]
    [SerializeField] private GameObject[] Bullets;
    [SerializeField] private Transform firepoint;
    [SerializeField] private float AttackCooldown;
    
    [Header("Collider")]
    [SerializeField] private float colliderDistance;
    [SerializeField] private float range;

    [Header("Hit box")]
    [SerializeField] private BoxCollider2D _boxCollider2D;
    [SerializeField] private LayerMask playerLayer;
    
    private Animator _animator;
    private float cooldownTimer = Mathf.Infinity;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _boxCollider2D = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        cooldownTimer += Time.deltaTime;

        if (PlayerInRange())
        {
            if (cooldownTimer >= AttackCooldown)
            {
                //* Run animation from the animator
                _animator.SetTrigger("Attack");
                Attack();
                cooldownTimer = 0;
            }
        }
    }
    
    private bool PlayerInRange()
    {
        RaycastHit2D hit = Physics2D.BoxCast(_boxCollider2D.bounds.center + transform.right * colliderDistance * transform.localScale.x * range, 
            new Vector3(_boxCollider2D.bounds.size.x * colliderDistance, _boxCollider2D.bounds.size.y, _boxCollider2D.bounds.size.z), 
            0, Vector2.left, 0, playerLayer);
        return hit.collider != null;
    }

    private void Attack()
    {
        cooldownTimer = 0;
        Bullets[FindBullet()].transform.position = firepoint.position;
        Bullets[FindBullet()].GetComponent<PeashooterProjecile>().ActiveProjectile(Mathf.Sign(transform.localScale.x));
    }
    
    private int FindBullet()
    {
        for (int i = 0; i < Bullets.Length; i++)
        {
            if (!Bullets[i].activeInHierarchy)
            {
                return i;
            }
        }
        return 0;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(_boxCollider2D.bounds.center + transform.right * colliderDistance * range * transform.localScale.x, 
            new Vector3(_boxCollider2D.bounds.size.x * colliderDistance, _boxCollider2D.bounds.size.y, _boxCollider2D.bounds.size.z));
    }
}
