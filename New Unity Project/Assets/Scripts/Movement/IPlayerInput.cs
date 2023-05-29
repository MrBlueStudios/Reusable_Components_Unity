using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Movement
{
    internal interface IPlayerInput
    {
        Vector3 GetMovementInput();
    }
}
