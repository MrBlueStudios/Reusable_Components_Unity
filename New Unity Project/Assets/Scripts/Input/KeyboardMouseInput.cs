using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Input
{
    public class KeyboardMouseInput : MonoBehaviour, IInputDevice
    {
        // get mouse inpuut for the horizontal and vertical input
        public float GetHorizontalInput()
        {
            return UnityEngine.Input.mousePosition.x;
        }

        // getvertical
        public float GetVerticalInput()
        {
            return UnityEngine.Input.mousePosition.y;
        }

        // getjump
        public bool GetJumpInput()
        {
            return UnityEngine.Input.GetButtonDown("JumpKey");
        }

        // getattack
        public bool GetAttackInput()
        {
            return UnityEngine.Input.GetButtonDown("Fire1");
        }

        // getinteract
        public bool GetInteractInput()
        {
            return UnityEngine.Input.GetButtonDown("Fire2");
        }

        // getpause
        public bool GetPauseInput()
        {
            return UnityEngine.Input.GetButtonDown("Pause");
        }

        // getmoveinputvector
        public Vector2 GetMoveInputVector()
        {
            // keyboard move input
            return new Vector2(UnityEngine.Input.GetAxisRaw("Horizontal"), UnityEngine.Input.GetAxisRaw("Vertical"));
        }

        // getsprint
        public bool GetSprintInput()
        {
            return UnityEngine.Input.GetButton("Sprint");
        }

        // getcrouch
        public bool GetCrouchInput()
        {
            return UnityEngine.Input.GetButton("Crouch");
        }
    }
}
