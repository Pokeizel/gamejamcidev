using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public Queue<string> dialogue_lines;
    // Start is called before the first frame update
    void Start()
    {
        dialogue_lines = new Queue<string>();
    }

    void Update() {

    }

    // Update is called once per frame
    public void StartDialogue(Dialogue dialogue)
    {
        string s = dialogue.name + ": ";
        for (int i = 0; i < dialogue.sentences.Length; i++) {
            s += dialogue.sentences[i] + "\n";
        }
        //Debug.Log(s);

        dialogue_lines.Clear();
        foreach (string sentence in dialogue.sentences) {
            dialogue_lines.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    void DisplayNextSentence() {
        if (dialogue_lines.Count == 0) {
            EndDialogue(); return;
        }

        string sentence = dialogue_lines.Dequeue();
        Debug.Log(sentence);
    }

    void EndDialogue() {
        Debug.Log("fin.");
    }
}
