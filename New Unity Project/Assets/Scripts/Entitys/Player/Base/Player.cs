using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Atributes;
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
        // camera reference
        [SerializeField] private IPlayerCam playerCam;
        // health reference
        [SerializeField] private Health health;

        // start
        private void Start()
        {
            // get components
            inputDevice = GetComponent<IInputDevice>();
            movement = GetComponent<MovementBase>();
            playerCam = GetComponent<IPlayerCam>();
            health = GetComponent<Health>();
        }

        // update
        private void Update()
        {
            // get input
            //movement.MyInput(inputDevice);
        }

    }
}
