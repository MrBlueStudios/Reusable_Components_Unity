using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using Assets.Scripts.interfaces;
using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Views.Camera.Types
{
    using UnityEngine;
    public class FirstPersonCamera : MonoBehaviour, ICam
    {
        // serialized fields
        //[SerializeField] private float sensitivity = 100f;
        [SerializeField] private Transform orientation;

        private float xRotation = 0f;
        private float yRotation = 0f;

        private Camera camera;

        public Transform FollowTarget { get; set; }
        public IInputDevice InputDevice { get; set; }

        [SerializeField] private IInputDevice _inputDevice;

        [SerializeField] private Transform _followTarget;

        // Start is called before the first frame update
        public void Start()
        {
            // lock cursor to center of screen
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

            camera = Camera.main;

            // get input device
            if (_inputDevice == null){_inputDevice = InputDevice;}
            if (_followTarget == null) { _followTarget = FollowTarget;}

        }

        // Update is called once per frame
        public void Update()
        {
            // get input
            float mouseX = _inputDevice.GetHorizontalInput();
            float mouseY = _inputDevice.GetVerticalInput();

            // calculate rotation
            xRotation -= mouseY;
            yRotation += mouseX;

            camera = Camera.main;
            camera.transform.position = FollowTarget.position;
            camera.transform.rotation = Quaternion.Euler(xRotation, yRotation, 0f);

            // clamp rotation
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        }

        public void ChangeCamera(ICam cam, Vector3 direction)
        {
            // 
        }

        public void OnBecomeActive(Vector3 direction)
        {
            throw new NotImplementedException();
        }
    }
}

