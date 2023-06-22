// third person camera unity

using Assets.Scripts.Atributes;
using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Views.Camera.Types
{
    /*public class ThirdPersonMovement : MonoBehaviour
    {
        [SerializeField] private float speed = 5f;
        [SerializeField] private float turnSmoothTime = 0.1f;

        private Rigidbody rb;
        private Transform cameraTransform;
        private float turnSmoothVelocity;

        public Transform FollowTarget { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }


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

        public void ChangeCamera(ICam cam, Vector3 direction)
        {
            throw new System.NotImplementedException();
        }

        public void OnBecomeActive(Vector3 direction)
        {
            throw new System.NotImplementedException();
        }
    }*/

    // new third person cam
    public class ThirdPersonCam : FaceTowards, ICam
    {
        // header
        [Header("Camera Settings")][SerializeField]
        private float distance = 5f;

        [SerializeField] private float height = 2f;
        [SerializeField] private float smoothSpeed = 0.5f;
        [SerializeField] private float rotationSpeed = 5f;

        // private variables
        private Transform target;

        public Transform FollowTarget { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        Transform ICam.FollowTarget { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        IInputDevice ICam.InputDevice { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void ChangeCamera(ICam cam, Vector3 direction)
        {
            throw new System.NotImplementedException();
        }

        public void OnBecomeActive(Vector3 direction)
        {
            throw new System.NotImplementedException();
        }

        // make a ThirdPersonCamera That uses the FaceTowards script to face the player(which is already made). The ThirdPersonCamera should also implement an interface called IPlayerCam 


    }
}