using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DialogueSpeaker : MonoBehaviour
{
    public Dialogue dialogue;
    public List<Dialogue.lineData> lines;

    public void triggerDialogue () {
        FindObjectOfType<DialogueManager>().StartDialogue(lines);
    }
}
