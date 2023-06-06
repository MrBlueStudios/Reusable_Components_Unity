using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Movement
{
    internal class MovementBase : MonoBehaviour
    {
        [SerializeField] protected float speed = 12f;

        private Vector2 moveInput;
        // get input
        protected void MyInput(IInputDevice inputDevice)
        {
            // get input
            moveInput = inputDevice.GetMoveInputVector();
            /*horizontalInput = inputDevice.GetMoveInputVector().x;
            verticalInput = inputDevice.GetMoveInputVector().y;*/

            // jump
            if (inputDevice.GetJumpInput())
            {
                Jump();
            }
        }

        // virtual jump
        protected virtual void Jump()
        {
        }

        // move
        protected virtual void Move(Vector2 moveInput)
        {

        }

        // fixed update
        private void FixedUpdate()
        {
            Move(moveInput);
        }
    }
}
