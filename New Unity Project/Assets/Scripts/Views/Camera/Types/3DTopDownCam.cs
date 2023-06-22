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
    internal class _3DTopDownCam : ICam
    {
        public void Start()
        {
            // 
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        private GameObject Player { get; set; }
        public Transform FollowTarget { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IInputDevice InputDevice { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void ChangeCam()
        {
            throw new NotImplementedException();
        }

        public void ChangeCamera(ICam cam, Vector3 direction)
        {
            throw new NotImplementedException();
        }

        public void OnBecomeActive(Vector3 direction)
        {
            throw new NotImplementedException();
        }
    }
}
