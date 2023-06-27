using Assets.Scripts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

// InteractionAreaSphere class
public class InteractionAreaSphere : MonoBehaviour, IInteractable
{
    [SerializeField] private float interactionRadius = 2f;

    private void Update()
    {
        // Check for player input or any other condition to initiate interaction
        if (Input.GetKeyDown(KeyCode.E))
        {
            Collider[] colliders = Physics.OverlapSphere(transform.position, interactionRadius);
            foreach (var collider in colliders)
            {
                IInteractable interactable = collider.GetComponent<IInteractable>();
                if (interactable != null)
                {
                    interactable.Interact();
                }
            }
        }
    }

    public void Interact()
    {
        // Implement the interaction logic for the sphere
        Debug.Log("Interacting with InteractionAreaSphere");
    }
}