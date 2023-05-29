using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float distance = 5.0f;
    public float height = 3.0f;
    public float rotationDamping = 2.0f;
    public float heightDamping = 2.0f;
    public float mouseSensitivity = 2.0f;

    private float currentRotation = 0.0f;
    private float desiredRotation = 0.0f;

    private void LateUpdate()
    {
        if (!target)
            return;

        // Adjust the camera rotation based on mouse input
        desiredRotation += Input.GetAxis("Mouse X") * mouseSensitivity;

        // Smoothly rotate the camera towards the desired rotation
        currentRotation = Mathf.Lerp(currentRotation, desiredRotation, rotationDamping * Time.deltaTime);

        Quaternion rotation = Quaternion.Euler(0, currentRotation, 0);

        // Set the camera position and rotation
        Vector3 position = target.position - (rotation * Vector3.forward * distance);
        position.y = Mathf.Lerp(transform.position.y, target.position.y + height, heightDamping * Time.deltaTime);
        transform.position = position;

        transform.LookAt(target);
    }
}
