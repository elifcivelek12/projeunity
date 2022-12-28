using UnityEngine;
using System.Collections;

public class dsmovement : MonoBehaviour
{
    Rigidbody2D enemyRigidBody2D;
    public int UnitsToMove = 3;
    public float EnemySpeed = 500;
    public bool FacingRight;
    private float startPos;
    private float endPos;

    public bool moveRight = true;


    
    public void Awake()
    {
         enemyRigidBody2D = GetComponent<Rigidbody2D>();
         startPos = transform.position.x;
         endPos = startPos + UnitsToMove;
         FacingRight = transform.localScale.x > 0;
    }



public void Update()
{

    if (moveRight)
    {
        enemyRigidBody2D.AddForce(Vector2.right * EnemySpeed * Time.deltaTime);
        if (!FacingRight)
            Flip();
    }

    if (enemyRigidBody2D.position.x >= endPos)
        moveRight = false;

    if (!moveRight)
    {
        enemyRigidBody2D.AddForce(-Vector2.right * EnemySpeed * Time.deltaTime);
        if (FacingRight)
            Flip();
    }
    if (enemyRigidBody2D.position.x <= startPos)
        moveRight = true;


}

    public void Flip()
    {
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        FacingRight = transform.localScale.x > 0;
    }

}