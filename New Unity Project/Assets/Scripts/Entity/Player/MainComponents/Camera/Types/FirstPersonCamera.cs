using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using Assets.Scripts.Player.Base;
using UnityEngine;

internal class FirstPersonCamera : Camera, IPlayerCam, IPlayerComponent
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void IPlayerCam.Start()
    {
        throw new System.NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void IPlayerCam.Update()
    {
        throw new System.NotImplementedException();
    }
}
