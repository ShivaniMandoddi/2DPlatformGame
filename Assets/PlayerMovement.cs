using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float playerSpeed;
    public float playerJumpForce;
    public LayerMask layerMask;
    public Transform groundCheck;
    float xInput, yInput;
    Rigidbody2D rb;
    bool IsFacingRight;
    bool IsGrounded;
    public float checkRadius;

    private void Awake()
    {
        rb=GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        IsFacingRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        IsGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, layerMask);
        xInput = Input.GetAxis("Horizontal");
        rb.velocity=new Vector2(xInput*playerSpeed,rb.velocity.y);
        if (IsFacingRight == false && xInput > 0)
        {
            Flip();
        }
        else if (IsFacingRight == true && xInput < 0)
        {
            Flip();
        }
        if(Input.GetButtonDown("Fire1") && IsGrounded==true)
        {
            rb.velocity = Vector2.up * playerJumpForce;
            
        }

        // yInput = Input.GetAxis("Vertical");
    }

    private void Flip()
    {
        IsFacingRight = !IsFacingRight;
        transform.Rotate(0, 180, 0);
    }
}
