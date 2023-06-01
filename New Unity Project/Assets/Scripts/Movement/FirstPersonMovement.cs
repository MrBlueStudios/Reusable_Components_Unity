using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Assets.Scripts;
using Assets.Scripts.interfaces;

public class FirstPersonMovement : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float speed = 12f;
    [SerializeField] private Transform orientation;
    /*[SerializeField] private float gravity = -9.81f;
    [SerializeField] private float jumpHeight = 3f;
    */
    [SerializeField] private float groundDrag;

    [Header("Ground Check")]
    [SerializeField] private float playerHeight;
    [SerializeField] private LayerMask groundMask;
    bool isGrounded;

    private float horizontalInput;
    private float verticalInput;

    private Vector3 moveDirection;
    private Vector3 velocity;

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    // update
    private void Update()
    {
        // ground check
        isGrounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, groundMask);

        MyInput();
        SpeedControl();

        // handle drag
        if (isGrounded)
        {
            rb.drag = groundDrag;
        }
        else
        {
            rb.drag = 0f;
        }
    }

    // fixed update
    private void FixedUpdate()
    {
        Move();
    }

    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    // move player
    private void Move()
    {

        // calculate direction
        moveDirection = transform.right * horizontalInput + transform.forward * verticalInput;

        rb.AddForce(moveDirection.normalized * speed * 10f, ForceMode.Force);
    }

    private void SpeedControl()
    {
        Vector3 flatVelocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        // limit if needed
        if (flatVelocity.magnitude > speed)
        {
            Vector3 limitedVelocity = flatVelocity.normalized * speed;
            rb.velocity = new Vector3(limitedVelocity.x, rb.velocity.y, limitedVelocity.z);
        }
    }
}

