
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Atributes;
using Assets.Scripts.Interfaces;
using UnityEngine;
using Assets.Scripts.Movement;
using Unity.VisualScripting;
using System;
using Assets.Scripts.Entitys.Player.Base;



namespace Assets.Scripts.Entitys.Player.Base
{
    using UnityEngine;
    using Assets.Scripts.Interfaces;

    public class Player : Entity, IHasName
    {
        // player name
        [Header("Player Name")]
        [SerializeField] private string playerName;
        // list of achievements
        [SerializeField] private List<MyAchievement> achievements;
        // myname
        public string MyName
        {
            get => playerName;
            set => playerName = value.ToLower().FirstCharacterToUpper();
        }

        [Header("Player Components")]
        [SerializeField] private IInputDevice inputDevice;
        [SerializeField] private ICam cameraController;
        [SerializeField] private MovementBase movementController;
        [SerializeField] private Inventory inventory;

        // start
        private void Start()
        {
            // set name
            MyName = playerName;
            // set input
            if (inputDevice == null)
            {
                inputDevice = GetComponent<IInputDevice>();
            }
            // set camera
            if (cameraController == null)
            {
                cameraController = GetComponent<ICam>();
                cameraController.FollowTarget = transform;
            }
            // set movement
            if (movementController == null)
            {
                movementController = GetComponent<MovementBase>();
            }
            // set inventory
            if (inventory == null)
            {
                inventory = GetComponent<Inventory>();
            }
            // set health
            if (health == null)
            {
                health = GetComponent<Health>();
            }
        }

        private void Update()
        {
            HandleInput();
        }

        private void HandleInput()
        {
            // Camera control
            if (cameraController != null)
            {
                cameraController.OnBecomeActive(transform.position);
            }

            // Movement control
            if (movementController != null)
            {
                float horizontal = Input.GetAxis("Horizontal");
                float vertical = Input.GetAxis("Vertical");
                //movementController.Move(horizontal, vertical);
            }

            // Inventory control
            if (inventory != null && Input.GetKeyDown(KeyCode.I))
            {
                inventory.OpenInventory();
            }

            // Health control
            if (health != null && Input.GetKeyDown(KeyCode.Space))
            {
                health.Damage(10);
            }
        }

        public void SetCameraController(ICam camera)
        {
            cameraController = camera;
        }

        public void SetMovementController(MovementBase movement)
        {
            movementController = movement;
        }

        public void SetInventory(Inventory newInventory)
        {
            inventory = newInventory;
        }

        public void SetHealthComponent(Health newHealthComponent)
        {
            health = newHealthComponent;
        }
    }

}
