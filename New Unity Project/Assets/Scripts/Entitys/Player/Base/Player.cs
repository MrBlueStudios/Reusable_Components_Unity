using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Interfaces;
using UnityEngine;
// interfaces
using Assets.Scripts.Interfaces;

namespace Assets.Scripts.Entitys.Player.Base
{
    public class Player : Entity
    {
        // serialized fields

        // Get IInputDevice
        [SerializeField] private IInputDevice inputDevice;



        // get controller
        /*[SerializeField] private IController controller;*/

        protected override void Initialize()
        {
            

            base.Initialize();
        }

        protected override void Update()
        {
            base.Update();
        }
    }
}
