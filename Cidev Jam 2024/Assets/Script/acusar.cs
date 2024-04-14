using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using static acusar;



public class acusar : MonoBehaviour 
{

    public Button yourButton;
    public GameObject popup;

  
    public enum estado
    {
        guilty,
        innocet,

    }

    public static class ButtonTagManager
    {
        public static estado selectedButtonTag; // Variable estática para almacenar la etiqueta del botón seleccionado
    }

    // Start is called before the first frame update
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        


        btn.onClick.AddListener(() =>
        {
            OutPopUp();
        });

     
    }

    // Update is called once per frame
    public void isTrueInnocet(){

      
        if (yourButton.gameObject.tag == "guilty") {

            ButtonTagManager.selectedButtonTag = estado.guilty;
            Debug.Log("tag" + yourButton.gameObject.tag);
            Debug.Log("selected" + ButtonTagManager.selectedButtonTag);

        }
        if (yourButton.gameObject.tag == "innocent")
        {
            ButtonTagManager.selectedButtonTag = estado.innocet;
            Debug.Log("tag" + yourButton.gameObject.tag);
            Debug.Log("selected" + ButtonTagManager.selectedButtonTag);

        }
       }


    public void OutPopUp() {
    
            popup.SetActive(true);
            isTrueInnocet();
    }


 


}
