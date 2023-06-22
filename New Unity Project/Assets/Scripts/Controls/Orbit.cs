using Assets.Scripts.Input;
using Assets.Scripts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Controls
{
    /*using UnityEngine;
    public class Orbit : MonoBehaviour
    {

        public float turnSpeed = 4.0f;
        public Transform player;

        private Vector3 offset;

        void Start()
        {
            // set mouse cursor to center of screen
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            offset = new Vector3(player.position.x, player.position.y + 8.0f, player.position.z + 7.0f);
        }

        void LateUpdate()
        {
            offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * offset;
            transform.position = player.position + offset;
            transform.LookAt(player.position);
        }
    }*/
/*    using UnityEngine;
    using System.Collections;
    using Assets.Scripts.Interfaces;
    using Assets.Scripts.Input;

    *//*[AddComponentMenu("Camera-Control/Mouse Orbit with zoom")]*//*
    public class Orbit : MonoBehaviour
    {

        public float turnSpeed = 4.0f;
        public Transform player;
        [Space(10)]
        public float height = 1f;
        public float distance = 2f;

        private Vector3 offsetX;
        private Vector3 offsetY;



        void Start()
        {

            offsetX = new Vector3(0, height, distance);
            offsetY = new Vector3(0, 0, distance);

            // set mouse cursor to center of screen
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

        }

        void LateUpdate()
        {
            // for moving left and right
            offsetX = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * offsetX;
            // for moving up and down
            offsetY = Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * turnSpeed, Vector3.right) * offsetY;

            // now apply the rotation to the camera
            transform.position = player.position + offsetX + offsetY;



*//*            transform.position = player.position + offsetX;
            // for moving up and down
            transform.position = player.position + offsetY;
            //transform.LookAt(player.position);*//*
        }
    }*/

    // version 2 of orbit will replace the first one
    public class Orbit : MonoBehaviour, ICam
    {
        // serialized fields
        // header for target which is the object to orbit around
        [Tooltip("The object to orbit around")]
        [SerializeField] public Transform FollowTarget { get => _currentTarget; set => _currentTarget = value; }
        private Transform _currentTarget;

        // header for input device
        [Header("Input Device")]
        [Tooltip("The input device to use")]
        [SerializeField] private IInputDevice _inputDevice;
        public IInputDevice InputDevice { get => _inputDevice; set => _inputDevice = value; }


        [Header("~~~ Camera Settings ~~~")]

        // header for camera sensitivity
        [Header("Camera Sensitivity")]
        [Tooltip("The sensitivity of the camera")]
        [SerializeField] private float sensitivity = 5f;


        // header for distance and height
        [Header("Distance and Height")]
        [Tooltip("The distance from the target")]
        [SerializeField] private float distance = 2f;
        [Tooltip("The height from the target")]
        [SerializeField] private float height = 1f;

        [Header("Clamp Movement")]
        // y axis clamp
        [Tooltip("The minimum y value")]
        [SerializeField] private float minY = 0f;
        [Tooltip("The maximum y value")]
        [SerializeField] private float maxY = 90f;
        [Space(10)]
        // x axis clamp
        [Tooltip("The minimum x value")]
        [SerializeField] private float minX = 0f;
        [Tooltip("The maximum x value")]
        [SerializeField] private float maxX = 90f;

        // Start is called before the first frame update
        void Start()
        {
            // set mouse cursor to center of screen
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        // Update is called once per frame
        void Update()
        {
            // if there is no target, return
            if (FollowTarget == null)
                return;

            // get the mouse input
            float mouseX = InputDevice.GetHorizontalInput();
            float mouseY = InputDevice.GetVerticalInput();

            // get the current rotation of the camera
            Vector3 currentRotation = transform.eulerAngles;

            // get the x and y rotation
            float x = currentRotation.x;
            float y = currentRotation.y;

            // add the mouse input to the x and y rotation
            x += mouseY * sensitivity * -1;
            y += mouseX * sensitivity;

            // clamp the x and y rotation
            x = Mathf.Clamp(x, minX, maxX);
            y = Mathf.Clamp(y, minY, maxY);

            // set the rotation
            transform.eulerAngles = new Vector3(x, y, 0);

            // get the current position of the camera
            Vector3 currentPosition = transform.position;

            // get the x and y position
            float xPos = currentPosition.x;
            float yPos = currentPosition.y;

            // set the x and y position
            xPos = FollowTarget.position.x;
            yPos = FollowTarget.position.y + height;

            // set the position
            transform.position = new Vector3(xPos, yPos, FollowTarget.position.z - distance);
        }

        // OnDrawGizmosSelected is called when the object is selected
        private void OnDrawGizmosSelected()
        {
            // draw a sphere at the target position
            Gizmos.color = Color.red;
            Gizmos.DrawSphere(FollowTarget.position, 0.5f);
        }


    }
}
