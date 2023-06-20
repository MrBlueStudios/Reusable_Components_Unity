using Assets.Scripts.Entitys.Player.Base;
using Assets.Scripts.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : Entity
{
    [SerializeField] private string npcName;
    [SerializeField] private float detectionRange = 10f;

    private Player playerComponent;

    private void Start()
    {

    }

    private void Update()
    {
        // Check if the player is within detection range
        if (playerComponent != null && Vector3.Distance(transform.position, playerComponent.transform.position) <= detectionRange)
        {
            // Perform NPC action when player is in range
            DoSomething();
            
        }

        // Perform other NPC logic...
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the collided object has the Player component
        Player player = other.GetComponent<Player>();
        if (player != null)
        {
            playerComponent = player;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Check if the collided object has the Player component
        Player player = other.GetComponent<Player>();
        if (player != null && player == playerComponent)
        {
            playerComponent = null;
        }
    }

    private void DoSomething()
    {
        // Add your NPC's action code here
        Debug.Log("NPC is doing something because the player is in range.");
    }
}
