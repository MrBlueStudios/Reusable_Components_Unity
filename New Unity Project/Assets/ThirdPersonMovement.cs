using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float turnSmoothTime = 0.1f;

    private Rigidbody rb;
    private Transform cameraTransform;
    private float turnSmoothVelocity;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        cameraTransform = UnityEngine.Camera.main.transform;
    }

    private void FixedUpdate()
    {
        float horizontal = UnityEngine.Input.GetAxisRaw("Horizontal");
        float vertical = UnityEngine.Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg +
                                cameraTransform.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity,
                turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDirection = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            rb.MovePosition(rb.position + moveDirection.normalized * speed * Time.fixedDeltaTime);
        }
    }
}
