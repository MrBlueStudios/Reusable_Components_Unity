using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    internal interface IPlayerCam
    {
        // every player cam must have a start method and an update method and the player object
        // must have a reference to the player cam object
        
        
        void Start();
        void Update();

    }
}
