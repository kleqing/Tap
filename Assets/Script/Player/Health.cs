using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealthh;
    private Animator animator;
    public float currentHealth { get; private set; }
    private bool isDead;
    
    private BoxCollider2D box;

    [Header("Physics Material")] 
    [SerializeField] private PhysicsMaterial2D noFriction;
    [SerializeField] private PhysicsMaterial2D Friction;

    private void Awake()
    {
        currentHealth = startingHealthh;
        animator = GetComponent<Animator>();
        box = GetComponent<BoxCollider2D>();
    }

    public void TakeDamage(float damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - damage, 0, startingHealthh);
        if (currentHealth > 0)
        {   
            animator.SetTrigger("Hurt");
        }
        else
        {
            if (!isDead)
            {
                isDead = true;
                animator.SetTrigger("Die");
                GetComponent<Player>().enabled = false;
                box.sharedMaterial = Friction; //* Set friction back to 0.4f
            }
        }
    }

    public void AddHealth(float healthValue)
    {
        currentHealth = Mathf.Clamp(currentHealth + healthValue, 0, startingHealthh);
    }

    public void Respawn()
    {
        isDead = false;
        AddHealth(startingHealthh);
        animator.ResetTrigger("Die");
        animator.Play("Idle");
        GetComponent<Player>().enabled = true;

        box.sharedMaterial = noFriction; //* Set friction to 0
    }
}
