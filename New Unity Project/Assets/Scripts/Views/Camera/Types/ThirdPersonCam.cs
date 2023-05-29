using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    /*internal class ThirdPersonCam : Camera, IPlayerCam
    {
        public void Start()
        {
            // TODO: implement this method
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        private GameObject Player { get; set; }

        public IPlayerCam GetOtherCam()
        {
            throw new NotImplementedException();
        }

        public void ChangeCam()
        {
            throw new NotImplementedException();
        }
    }*/


    using UnityEngine;

    public class ThirdPersonCam : MonoBehaviour
    {
        public Transform target;
        public float distance = 5.0f;
        public float height = 3.0f;
        public float rotationDamping = 2.0f;
        public float heightDamping = 2.0f;
        public float moveSpeed = 5.0f;

        private void LateUpdate()
        {
            if (!target)
                return;

            float desiredAngle = target.eulerAngles.y;
            float desiredHeight = target.position.y + height;

            Quaternion currentRotation = transform.rotation;
            Vector3 currentPosition = transform.position;

            // Smoothly rotate the camera towards the target angle
            currentRotation = Quaternion.Lerp(currentRotation, Quaternion.Euler(0, desiredAngle, 0), rotationDamping * Time.deltaTime);

            // Smoothly move the camera towards the desired height
            currentPosition.y = Mathf.Lerp(currentPosition.y, desiredHeight, heightDamping * Time.deltaTime);

            // Set the new position and rotation of the camera
            transform.position = target.position;
            transform.position -= currentRotation * Vector3.forward * distance;
            transform.position = new Vector3(transform.position.x, currentPosition.y, transform.position.z);
            transform.LookAt(target);
        }

        private void FixedUpdate()
        {
            // Read input for character movement
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            // Move the character based on input
            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            movement = Camera.main.transform.TransformDirection(movement);
            movement.y = 0.0f;
            movement.Normalize();
            movement *= moveSpeed;

            // Apply movement to the character's rigidbody
            Rigidbody characterRigidbody = target.GetComponent<Rigidbody>();
            characterRigidbody.velocity = movement;
        }
    }


}


