using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float movespeed = 5f;
    public float JumpForce = 10f;
    public LayerMask Tanah;

    private Rigidbody2D rb;
    private Animator anim;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        rb.velocity = new Vector2(movespeed, rb.velocity.y);

        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, 1f, Tanah);
        if(input.GetKeyDown(KeyCode.UpArrow) &&isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            anim.SetTrigger("Jump");
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            anim.SetTrigger("Slide");
        }
    }
}
