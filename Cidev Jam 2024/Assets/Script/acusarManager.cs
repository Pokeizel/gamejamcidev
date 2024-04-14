using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using static acusar;


public class acusarManager : MonoBehaviour
{
    public GameObject popup;
    public Button si;
    public Button no;

    void Start()
    {
        Button btn = si.GetComponent<Button>();
        Button btn1 = no.GetComponent<Button>();

        btn.onClick.AddListener(() =>
        {
            ChangeSceneByIndex();
        });

        btn1.onClick.AddListener(() =>
        {
            BackPopUp();
        });
    }

    public void BackPopUp()
    {
        popup.SetActive(false);
    }

    public void ChangeSceneByIndex()
    {
        Debug.Log("selected manager "  + ButtonTagManager.selectedButtonTag);
        if (ButtonTagManager.selectedButtonTag == estado.guilty)
        {
            
            SceneManager.LoadScene(2);
        }
        else
        {
            BackPopUp();
        }
      
    }
}