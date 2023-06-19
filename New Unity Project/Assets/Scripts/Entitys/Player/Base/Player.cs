using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Interfaces;
using UnityEngine;
// interfaces
using Assets.Scripts.Interfaces;
using Assets.Scripts.Movement;

namespace Assets.Scripts.Entitys.Player.Base
{
    public class Player : Entity
    {
        // controller reference
        [SerializeField] private IInputDevice inputDevice;
        // movement reference
        [SerializeField] private MovementBase movement;

    }
}
