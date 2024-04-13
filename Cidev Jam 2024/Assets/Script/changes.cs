using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class changes : MonoBehaviour
{
    public Button yourButton;
    public int index;

    public void Start()
    {

        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(() =>
        {
            ChangeSceneByIndex(); 
        });
    }

    public void ChangeSceneByIndex()
    {
        Debug.Log("hola");
        SceneManager.LoadScene(index);
    }
}
