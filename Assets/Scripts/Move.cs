using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Move : MonoBehaviour
{
    private Rigidbody2D rb2d;

    public float moveSpeed = 5;

    float horizontalInputDirection;
    private void Awake()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
    }
    private void MovePlayer(float speed)
    {
        horizontalInputDirection = Input.GetAxisRaw("Horizontal");

        if (horizontalInputDirection != 0)
        {
            rb2d.velocity = (Vector2.right * horizontalInputDirection) * speed;
            Debug.Log(rb2d.velocity);
        }
    }

    private void Update()
    {
        
        MovePlayer(moveSpeed);
    }
}