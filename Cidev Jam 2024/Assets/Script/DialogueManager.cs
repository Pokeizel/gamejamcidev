using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
    public SpriteRenderer spriteR;
    private Queue<Dialogue.lineData> lines;
    // Start is called before the first frame update
    void Start()
    {
        lines = new Queue<Dialogue.lineData>();
    }

    void Update() {
        if (Input.GetButtonDown("Fire1")) {
            Debug.Log("click!!!!");
            DisplayNextSentence();
        }
    }

    // Update is called once per frame
    public void StartDialogue(List<Dialogue.lineData> dialogueLines)
    {
        lines.Clear();

        foreach (Dialogue.lineData line in dialogueLines) {
            lines.Enqueue(line);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence() {
        if (lines.Count == 0) {
            EndDialogue(); return;
        }
        Dialogue.lineData line = lines.Dequeue();
        nameText.text = line.name;
        spriteR.sprite = line.portrait;
        StopAllCoroutines();
        StartCoroutine(UpdateTypewriter(line.sentence));
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
