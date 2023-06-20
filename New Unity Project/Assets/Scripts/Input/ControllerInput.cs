using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Interfaces;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class ControllerInput : MonoBehaviour, IInputDevice
{
    
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

    public float GetHorizontalInput()
    {
        throw new System.NotImplementedException();
        
    }

    public float GetVerticalInput()
    {
        throw new System.NotImplementedException();
    }

    // get left joystick

}
