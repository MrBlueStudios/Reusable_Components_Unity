using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;



// singleton DialogueManager class
public class DialogueManager : MonoBehaviour
{
    // static instance of the DialogueManager class
    public static DialogueManager Instance { get; private set; }

    private Queue<string> sentences;

    private void Start()
    {
        // Initialize the static instance of the DialogueManager class
        Instance = this;
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        // Clear the sentences queue
        sentences.Clear();
        // Enqueue all the sentences from the dialogue
        foreach (var sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        // Display the first sentence
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        // Check if there are any sentences left in the queue
        if (sentences.Count == 0)
        {
            // End the dialogue
            EndDialogue();
            return;
        }
        // Dequeue the next sentence
        string sentence = sentences.Dequeue();
        // Display the sentence
        Debug.Log(sentence);
    }

    public void EndDialogue()
    {
          // Implement the end of the dialogue
        Debug.Log("End of dialogue");
    }
}