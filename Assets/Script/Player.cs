using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 PlayerDirection;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        PlayerDirection = new Vector2 (0, directionY).normalized;
    }

    private void FixedUpdate()
    {
        rb .velocity = new Vector2(0, PlayerDirection.y * playerSpeed);
    }
}
