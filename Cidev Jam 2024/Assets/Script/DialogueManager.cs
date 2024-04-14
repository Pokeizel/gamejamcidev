using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.Reflection;
using UnityEngine.Events;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
    public SpriteRenderer spriteR;
    private Queue<Dialogue.lineData> lines;
    bool hasStarted = false;
    [Header("Events")]
    public GameEvent onDialogueFinished;
 
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
    public void StartDialogue(List<Dialogue.lineData> dialogueLines)
    {
        hasStarted = true;
        lines.Clear();

        foreach (Dialogue.lineData line in dialogueLines) {
            lines.Enqueue(line);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence() {
        if (lines.Count == 0 ) {
            EndDialogue(); return;
        }
        Dialogue.lineData line = lines.Dequeue();
        nameText.text = line.name;
        spriteR.sprite = line.portrait;
        StopAllCoroutines();
        StartCoroutine(UpdateTypewriter(line.sentence));
    }

    void EndDialogue() {
        if (hasStarted) onDialogueFinished.Raise();
        Debug.Log("fin.");
        /*
        if(SceneManager.GetActiveScene().buildIndex == 6 && !nextScene)
        {
            SceneManager.LoadScene(0);
           
        }
        if (!nextScene)
        {
            SceneManager.LoadScene(2);
        }
        else {*/
            Debug.Log("fin.");
        /*
            nextScene = false;
        }*/

    }

    IEnumerator UpdateTypewriter(string sentence) {
        dialogueText.text = "";
        foreach (char token in sentence.ToCharArray()) {
            dialogueText.text += token;
            yield return new WaitForSeconds(0.01f);
        }
        dialogueText.text = sentence;
    }
}
