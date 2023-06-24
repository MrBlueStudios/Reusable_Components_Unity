using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Atributes;
using Assets.Scripts.Interfaces;
using UnityEngine;
using Assets.Scripts.Movement;

namespace Assets.Scripts.Entitys.Player.Base
{
    public class Player : Entity
    {
        // fields
        [Header("Player")]
        // name
        [SerializeField] public string playerName;
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
