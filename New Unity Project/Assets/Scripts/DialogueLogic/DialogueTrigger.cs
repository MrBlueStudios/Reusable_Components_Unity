using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class  DialogueTrigger : MonoBehaviour
{
    [SerializeField] private Dialogue dialogue;

    public void TriggerDialogue()
    {
        // Start the dialogue
        DialogueManager.Instance.StartDialogue(dialogue);
    }
}