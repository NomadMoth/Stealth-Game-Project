using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Input
        MoveInput();
    }

    void FixedUpdate()
    {
        // Movement
        Movement();
    }

    public void MoveInput()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    public void Movement()
    {
        rb.MovePosition(rb.position + movement.normalized * moveSpeed * Time.deltaTime);
    }
}
