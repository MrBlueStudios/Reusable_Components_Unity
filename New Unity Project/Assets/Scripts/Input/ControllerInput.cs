using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Interfaces;
using UnityEngine;

public class ControllerInput : MonoBehaviour, IInputDevice{
    // gethorizontal
    public float GetHorizontalInput()
    {
        // right joystick
        return 
    }

    // getvertical
    public float GetVerticalInput()
    {
        // right joystick

    }
    // getjump
    public bool GetJumpInput()
    {
        return Input.GetButtonDown("Jump");
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
        return new Vector2(GetHorizontalInput(), GetVerticalInput());
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
