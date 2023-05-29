using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Movement
{
    using UnityEngine;

    public class Movementtest : MonoBehaviour
    {
        public float moveSpeed = 5.0f;
        public float jumpForce = 5.0f;
        public Transform groundCheck;
        public LayerMask groundLayer;

        private Rigidbody rb;
        private bool isGrounded = true;

        private void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            // Check if the player is on the ground
            isGrounded = Physics.CheckSphere(groundCheck.position, 0.2f, groundLayer);

            // Handle player movement
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            movement = Camera.main.transform.TransformDirection(movement);
            movement.y = 0.0f;
            movement.Normalize();
            movement *= moveSpeed;

            rb.velocity = new Vector3(movement.x, rb.velocity.y, movement.z);

            // Handle player jump
            if (Input.GetButtonDown("Jump") && isGrounded)
            {
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
        }
    }

}
