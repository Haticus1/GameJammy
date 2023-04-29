using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playermovement : MonoBehaviour
{

    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;

    void FixedUpdate()
    {
        rb.velocity = movement * moveSpeed * Time.fixedDeltaTime;
    }

    public void OnMove(InputValue value)
    {
        movement = value.Get<Vector2>();
    }

}
