using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Movement
{
    public class KeyboardInput : IPlayerInput
    {
        Vector3 IPlayerInput.GetMovementInput()
        {
            throw new NotImplementedException();
        }
    }
}
