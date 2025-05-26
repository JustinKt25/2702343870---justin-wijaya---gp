using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    public Transform groundCheck;
    public float groundDistance = 0.2f;
    public LayerMask groundMask;

    private Rigidbody2D rb;
    private Animator anim;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(x * moveSpeed, rb.velocity.y);

        
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundDistance, groundMask);

        
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
        float y = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(x * moveSpeed, rb.velocity.y);

        
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundDistance, groundMask);

        
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}
