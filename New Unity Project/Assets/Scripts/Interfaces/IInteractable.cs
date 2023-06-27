using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.Scripts.Interaction;

namespace Assets.Scripts.Interfaces
{
    public interface IInteractable
    {
        void Interact();

        // an IInteractable needs to have an InteractionArea
        //InteractionArea InteractionArea { get; set; }
    }
}
