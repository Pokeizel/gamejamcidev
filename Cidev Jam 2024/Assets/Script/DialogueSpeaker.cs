using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DialogueSpeaker : MonoBehaviour
{
    public Dialogue dialogue;

    public void triggerDialogue () {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
