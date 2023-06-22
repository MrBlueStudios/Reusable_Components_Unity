using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Input
{
    using UnityEngine;
    public class KeyboardMouseInput : MonoBehaviour, IInputDevice
    {
        // get mouse inpuut for the horizontal and vertical input
        public float GetHorizontalInput()
        {
            return Input.mousePosition.x;
        }

        // getvertical
        public float GetVerticalInput()
        {
            return Input.mousePosition.y;
        }

        // getjump
        public bool GetJumpInput()
        {
            return Input.GetButtonDown("JumpKey");
        }

        // getattack
        public bool GetAttackInput()
        {
            return Input.GetButtonDown("Fire1");
        }

        // getinteract
        public bool GetInteractInput()
        {
            return Input.GetButtonDown("Fire2");
        }

        // getpause
        public bool GetPauseInput()
        {
            return Input.GetButtonDown("Pause");
        }

        // getmoveinputvector
        public Vector2 GetMoveInputVector()
        {
            // keyboard move input
            return new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        }

        // getsprint
        public bool GetSprintInput()
        {
            return Input.GetButton("Sprint");
        }

        // getcrouch
        public bool GetCrouchInput()
        {
            return Input.GetButton("Crouch");
        }
    }
}
