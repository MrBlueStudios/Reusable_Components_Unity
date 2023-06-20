using Assets.Scripts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Interaction
{
    public class InteractionArea : MonoBehaviour
    {
        [SerializeField] private float interactionRange = 5f;

        private void OnDrawGizmosSelected()
        {
            // Draw a gizmo of a sphere to represent the interaction area
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(transform.position, interactionRange);
        }

        private void OnTriggerEnter(Collider other)
        {
            // Check if the collided object has an IInteractable component
            IInteractable interactable = other.GetComponent<IInteractable>();
            if (interactable != null)
            {
                interactable.Interact();
            }
        }
    }
}
