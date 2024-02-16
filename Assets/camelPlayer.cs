using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camelPlayer : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D coll;
    private SpriteRenderer sprite;
    private Animator anim;
    [SerializeField] private float moveSpeed = 2f;
    [SerializeField] private float accelerationRate = 0.5f; // Increase this value for faster acceleration
    [SerializeField] private float decelerationRate = 0.2f; // Increase this value for faster deceleration

    private float moveSpeedMultiplier = 1f;
    private bool isSpacePressed = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isSpacePressed = true;
            moveSpeedMultiplier += accelerationRate;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            isSpacePressed = false;
        }

        if (!isSpacePressed)
        {
            moveSpeedMultiplier = Mathf.Max(1f, moveSpeedMultiplier - decelerationRate);
        }

        rb.velocity = new Vector2(moveSpeed * moveSpeedMultiplier, rb.velocity.y);
    }
}
