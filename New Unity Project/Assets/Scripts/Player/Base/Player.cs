using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Player.Base
{
    internal class Player : IPlayer
    {
        private List<IPlayerComponent> _playerComponents;

        private IPlayerCam playerCam;
        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
