using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueBox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown() {
        Debug.Log("click");
        FindObjectOfType<DialogueManager>().DisplayNextSentence();  
    }

    public void GoToMap() {
        SceneManager.LoadScene(2);
    }
    public void GoToTitle() {
        SceneManager.LoadScene(0);
    }
}
