using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    public LayerMask groundLayers;
    public bool isGrounded;

    // Start is called before the first frame update
    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        float xAxis = Input.GetAxisRaw("Horizontal");
        rigidBody.velocity = new Vector2(xAxis * 5f, rigidBody.velocity.y);

        isGrounded = IsGrounded();

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            rigidBody.velocity += new Vector2(0, 5f);
        }
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapArea(
            new Vector2(transform.position.x - .5f, transform.position.y - .5f),
            new Vector2(transform.position.x + .5f, transform.position.y - .51f),
            groundLayers
        );
    }

}
