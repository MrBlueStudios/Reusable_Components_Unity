using Assets.Scripts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Interaction
{
    public class InteractionArea : MonoBehaviour// the interaction area for the player
    {
        [SerializeField] private float interactionRange = 5f;

        private void OnDrawGizmosSelected()
        {
            // Draw a gizmo of a sphere to represent the interaction area
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, interactionRange);
        }
        // while in the interaction area
        
        private void OnTriggerEnter(Collider other)
        {
            // keep a variable for the distance between the player and the object
            float distance = Vector3.Distance(transform.position, other.transform.position);
            // Check if the collided object has an IInteractable component
            IInteractable interactable = other.GetComponent<IInteractable>();
            if (interactable != null)
            {
                interactable.Interact();
            }
        }
    }
}
