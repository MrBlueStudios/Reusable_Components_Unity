using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.Scripts.interfaces;
using UnityEngine;

namespace Assets.Scripts
{
    internal class _3DTopDownCam : IPlayerCam, IPlayerComponent
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

        public void ChangeCam()
        {
            throw new NotImplementedException();
        }

    }
}
