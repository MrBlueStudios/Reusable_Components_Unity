/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Assets.Scripts.Entity.Base;
using Assets.Scripts.Player.Base;
using Assets.Scripts.Player.Base.PlayerComponent;
using Assets.Scripts.Player.Base.PlayerCam;
using Assets.Scripts.Entity.Base.Enity;



namespace Assets.Scripts.Entity.Player.Base
{
    public class Player : IEntity, IPlayer
    {
        private bool is2D;

        private List<IPlayerComponent> _playerComponents;

        private IPlayerCam playerCam;

        public override void Initialize()
        {
            base.Initialize();
            is2D = true; // Start in 2D dimension
        }

        public override void Update()
        {
            base.Update();

            // Update logic for the player

            if (Input.GetKeyDown(KeyCode.Space))
            {
                SwitchDimension();
            }
        }

        private void SwitchDimension()
        {
            is2D = !is2D;

            if (is2D)
            {
                // Switch to 2D dimension
                Debug.Log("Switching to 2D dimension...");
            }
            else
            {
                // Switch to 3D dimension
                Debug.Log("Switching to 3D dimension...");
            }
        }
    }
}
*/

using Assets.Scripts.Entity.Base;
using Assets.Scripts.Interfaces;

public class Player : Entity
{
    protected override void Initialize()
    {
        base.Initialize();
    }

    protected override void Update()
    {
        base.Update();
    }
}