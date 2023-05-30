using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using Assets.Scripts.interfaces;
using UnityEngine;

internal class FirstPersonCamera : Camera, IPlayerCam, IPlayerComponent
{
    // serialized fields
    [SerializeField] private float sensitivity = 100f;
    [SerializeField] private Transform playerBody;
    [SerializeField] private Transform cameraBody;
    
    

    // Start is called before the first frame update
    public void Start()
    {
        // lock cursor to center of screen
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    public void Update()
    {



    }

    // change cam
    public void ChangeCam()
    {
        // change cam to 3D top down cam
        throw new System.NotImplementedException();

    }

}
