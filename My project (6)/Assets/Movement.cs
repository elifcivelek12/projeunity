using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rigidBody;

    public LayerMask groundLayers;
    public bool isGrounded;
    public int jumpIncreaseTimer;

    public Sprite idleSprite;
    public Sprite movingSprite;
    
    private SpriteRenderer renderer2;

    // Start is called before the first frame update
    private void Start()
    {
        renderer2 = GetComponent<SpriteRenderer>();
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        float xAxis = Input.GetAxisRaw("Horizontal");

        if(xAxis > 0)
        {
            renderer2.sprite = movingSprite;
            renderer2.flipX = false;
        } else if(xAxis < 0)
        {
            renderer2.sprite = movingSprite;
            renderer2.flipX = true;
        } else
        {
            renderer2.sprite = idleSprite;
            renderer2.flipX = false;
        }

        rigidBody.velocity = new Vector2(xAxis * 5f, rigidBody.velocity.y);

        isGrounded = IsGrounded();

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            rigidBody.velocity += new Vector2(0, jumpIncreaseTimer > 0? 10:8);
        }

        if(jumpIncreaseTimer > 0)
        {
            jumpIncreaseTimer--;
        }
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapArea(
            new Vector2(transform.position.x - .45f, transform.position.y - .7f),
            new Vector2(transform.position.x + .45f, transform.position.y - .71f),
            groundLayers
        );
    }

}
