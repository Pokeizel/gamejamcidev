using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
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
        nameText.text = dialogue.name;
        dialogue_lines.Clear();
        foreach (string sentence in dialogue.sentences) {
            dialogue_lines.Enqueue(sentence);
        }

        DisplayNextSentence();

    }

    public void DisplayNextSentence() {
        if (dialogue_lines.Count == 0) {
            EndDialogue(); return;
        }

        string sentence = dialogue_lines.Dequeue();
        Debug.Log(sentence);
        dialogueText.text = sentence;
        StopAllCoroutines();
        StartCoroutine(UpdateTypewriter(sentence));
    }

    void EndDialogue() {
        Debug.Log("fin.");
    }

    IEnumerator UpdateTypewriter(string sentence) {
        dialogueText.text = "";
        foreach (char token in sentence.ToCharArray()) {
            dialogueText.text += token;
            yield return new WaitForSeconds(0.01f);
        }
    }
}
