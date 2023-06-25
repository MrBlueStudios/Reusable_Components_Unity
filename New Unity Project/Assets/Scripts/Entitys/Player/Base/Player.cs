using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Atributes;
using Assets.Scripts.Interfaces;
using UnityEngine;
using Assets.Scripts.Movement;
using Unity.VisualScripting;
using System;

namespace Assets.Scripts.Entitys.Player.Base
{
    public class Player : Entity, IHasName
    {
        // player name
        [Header("Player Name")]
        [SerializeField] private string playerName;

        // myname
        public string MyName { get => playerName; set => playerName = value.ToLower().FirstCharacterToUpper(); }

        // list of achievements
        [SerializeField] private List<MyAchievement> achievements;

        // check if player has movement and a IPlayerCam attached
        private void Awake()
        {
            /*if (GetComponent<IInputDevice>() == null)
            {
                // throw error
                throw new System.Exception("Player: " + playerName + " has no IInputDevice script attached");
            }
            if (GetComponent<MovementBase>() == null)
            {
                // throw error
                throw new System.Exception("Player: " + playerName + " has no MovementBase script attached");
            }
            if (GetComponent<ICam>() == null)
            {
                // throw error
                throw new System.Exception("Player: " + playerName + " has no IPlayerCam script attached");
            }*/
        }

    }
}   
