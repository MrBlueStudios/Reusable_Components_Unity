using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using Assets.Scripts.interfaces;
using UnityEngine;

internal class FirstPersonCamera : Camera, IPlayerCam, IPlayerComponent
{
    // serialized fields
    //[SerializeField] private float sensitivity = 100f;
    [SerializeField] private Transform orientation;

    private float xRotation = 0f;
    private float yRotation = 0f;
    

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
        // move camera so it follows the player
        this.camera.position = this.playerBody.position;
        // get mouse input
        float mouseX = Input.GetAxis("Mouse X") * this.sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * this.sensitivity * Time.deltaTime;

        xRotation -= mouseY;
        yRotation += mouseX;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
        this.playerBody.rotation = Quaternion.Euler(0f, yRotation, 0f);
    }

    // change cam
    public void ChangeCam()
    {
        // change cam to 3D top down cam
        throw new System.NotImplementedException();

    }

}
