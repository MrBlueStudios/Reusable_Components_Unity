using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using Assets.Scripts.interfaces;
using UnityEngine;

internal class FirstPersonCamera : Camera, IPlayerCam, IPlayerComponent
{
    // private variables
    private float xRotation = 0f;
    private float yRotation = 0f;

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

        // set camera position to player position + offset so that the camera is around head level based on 80% of the player's height
        cameraBody.position = playerBody.position + new Vector3(0, playerBody.localScale.y * 0.8f, 0);



    }

    // Update is called once per frame
    public void Update()
    {
        // get mouse input
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;

        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        // rotate camera based on mouse input using new functions
        RotateCamera(mouseX, mouseY);

        // move camera to player position + offset so that the camera is around head level based on 80% of the player's height
        cameraBody.position = playerBody.position + new Vector3(0, playerBody.localScale.y * 0.8f, 0);



    }

    private void RotateCamera(float mouseX, float mouseY)
    {
        // first person camera calculation

    }

    public IPlayerCam GetOtherCam()
    {
        throw new System.NotImplementedException();
    }

    // change cam
    public void ChangeCam()
    {
        // change cam to 3D top down cam
        throw new System.NotImplementedException();

    }

}
