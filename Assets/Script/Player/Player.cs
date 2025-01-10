using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Player Movement")]
    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpPower;
    [SerializeField] private LayerMask groundLayer;
    
    private BoxCollider2D boxCollider;
    private Rigidbody2D rb;
    private Animator anim;

    private float horizontalInput;
    
    [Header("Double Jump")]
    [SerializeField] private float jumpTime;
    private float jumpCount;
    
    [Header("SFX")]
    [SerializeField] private AudioClip jumpSFX;
    private void Awake()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    
    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if (horizontalInput > 0.01f)
        {
            transform.localScale = Vector3.one;
        }
        else if (horizontalInput < -0.01f)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        
        anim.SetBool("Run", horizontalInput != 0 && isGrounded());
        anim.SetBool("Jump", !isGrounded());

        //* Jump
        if (Input.GetButtonDown("Jump"))
        {
            SoundManager.Instance.PlaySound(jumpSFX);
            jumpCount = jumpTime;
            Jump();
        }
        
        //* Jumnp height control
        if ((Input.GetKeyUp(KeyCode.Space) || Input.GetKeyUp(KeyCode.W)) && rb.linearVelocity.y > 0)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, rb.linearVelocity.y / 2);
        }
        
        rb.gravityScale = 3;
        rb.linearVelocity = new Vector2(horizontalInput * moveSpeed, rb.linearVelocity.y);
        
    }

    private void Jump()
    {
        if (jumpCount <= 0)
        {
            return;
        }
        else
        {
            if (isGrounded())
            {
                rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpPower);

            }
            else
            {
                if (jumpCount > 0)
                {
                    rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpPower);
                    jumpCount--;
                }
            }
        }
    }
    
    private bool isGrounded()
    {
        RaycastHit2D raycastHit2D = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, Vector2.down, 0.1f, groundLayer);
        return raycastHit2D.collider != null;
    }
}
