using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealthh;
    private Animator animator;
    public float currentHealth { get; private set; }
    private bool isDead;

    private void Awake()
    {
        currentHealth = startingHealthh;
        animator = GetComponent<Animator>();
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
                gameObject.GetComponent<BoxCollider2D>().sharedMaterial.friction = 0.4f; //* Set friction back to 0.4f
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
    }
}
