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
    using UnityEngine;
    using System.Collections;
    /*[AddComponentMenu("Camera-Control/Mouse Orbit with zoom")]*/
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



/*            transform.position = player.position + offsetX;
            // for moving up and down
            transform.position = player.position + offsetY;
            //transform.LookAt(player.position);*/
        }
    }

    public class Orbit2 : MonoBehaviour // version 2 of orbit will replace the first one
    {
        // serialized fields
        // header for target which is the object to orbit around
        [Header("Target")]
        // inspector summary
        [Tooltip("The object to orbit around")]
        [SerializeField] private Transform target;
        [SerializeField] private float distance = 2f;
        [SerializeField] private float height = 1f;
        [SerializeField] private float rotationDamping;

    }
}
