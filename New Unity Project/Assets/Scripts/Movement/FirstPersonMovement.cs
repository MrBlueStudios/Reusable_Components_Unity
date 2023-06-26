using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Assets.Scripts;
using Assets.Scripts.interfaces;
using Assets.Scripts.Interfaces;
using Assets.Scripts.Movement;

internal class FirstPersonMovement : MovementBase
{
    [Header("Movement")]
    /*[SerializeField] private float speed = 12f;*/
    [SerializeField] private Transform orientation;
    [SerializeField] private float groundDrag;

    [SerializeField] private float jumpForce;
    [SerializeField] private float jumpCoolDown;
    [SerializeField] private float airMulitplier;

    [Header("Keybinds")]
    [SerializeField] private KeyCode jumpKey = KeyCode.Space;

    [Header("Ground Check")]
    [SerializeField] private float playerHeight;
    [SerializeField] private LayerMask groundMask;
    bool isGrounded;

    private float horizontalInput;
    private float verticalInput;

    private Vector3 moveDirection;
    private Vector3 velocity;

    Rigidbody rb;

    private IInputDevice inputDevice;

    private void Start()
    {
        inputDevice = GetComponent<IInputDevice>();
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    // update
    private void Update()
    {
        // ground check
        isGrounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, groundMask);

        MyInput(inputDevice);
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

    /*// fixed update
    private void FixedUpdate()
    {
        Move();
    }*/

    /*private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        // jump
        if (Input.GetKeyDown(jumpKey))
        {
            Jump();
        }
    }*/

    // get input
    /*protected override void MyInput(IInputDevice inputDevice)
    {
        horizontalInput = inputDevice.GetMoveInputVector().x;
        verticalInput = inputDevice.GetMoveInputVector().y;

        // jump
        if (inputDevice.GetJumpInput())
        {
            Jump();
        }
    }*/

    // move player
    public override void Move(Vector2 moveInput)
    {
        // calculate direction
        moveDirection = orientation.forward * moveInput.y + orientation.right * moveInput.x;

        rb.AddForce(moveDirection.normalized * speed * 10f, ForceMode.Force);

        /*// calculate direction
        moveDirection = transform.right * horizontalInput + transform.forward * verticalInput;

        rb.AddForce(moveDirection.normalized * speed * 10f, ForceMode.Force);*/
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

    private void Jump()
    {
        if (isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}

