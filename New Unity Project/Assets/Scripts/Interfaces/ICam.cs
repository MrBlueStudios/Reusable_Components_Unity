using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.Scripts.interfaces;
using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts
{
    public interface ICam
    {
        // object to follow
        Transform FollowTarget { get; set; }

        IInputDevice InputDevice { get; set; }

        // when changing from cam animation zooming in a sertain direction
        void ChangeCamera(ICam cam, Vector3 direction);

        // when becoming the active camera
        void OnBecomeActive(Vector3 direction);
    }
}
