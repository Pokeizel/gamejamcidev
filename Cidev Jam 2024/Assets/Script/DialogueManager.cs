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
        Debug.Log("yay");
    }
}
