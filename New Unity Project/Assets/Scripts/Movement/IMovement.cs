using UnityEngine;

namespace Assets.Scripts.Movement
{
    // movement interface
    public interface IMovement
    {
        // move
        void Move(Vector2 moveInput);

        // jump
        void Jump();


    }
}