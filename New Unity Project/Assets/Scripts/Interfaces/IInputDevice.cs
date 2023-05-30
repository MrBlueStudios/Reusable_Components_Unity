using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Interfaces
{
    internal interface IInputDevice
    {
        // horizontal and vertical input
        float GetHorizontalInput();
        float GetVerticalInput();

        // jump input
        bool GetJumpInput();

        // attack input
        bool GetAttackInput();

        // interact input
        bool GetInteractInput();

        // pause input
        bool GetPauseInput();

        // get move input vector
        Vector2 GetMoveInputVector();

        // get sprint input
        bool GetSprintInput();

        // get crouch input
        bool GetCrouchInput();
    }
}
