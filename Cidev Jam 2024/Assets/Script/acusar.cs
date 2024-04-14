using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class acusar : MonoBehaviour 
{

    public Button yourButton;
    public GameObject popup;


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
            
            Debug.Log("mal mal");
            ButtonTagManager.selectedButtonTag = "guilty";



        }
        if (yourButton.gameObject.tag == "innocent") 
        {
           
            
                Debug.Log("no era yo");
          
        }


        }


    public void OutPopUp() {
    
            popup.SetActive(true);
            isTrueInnocet();
    }

    public void BackPopUp()
    {

        popup.SetActive(false);

    }

    public static class ButtonTagManager
    {
        public static string selectedButtonTag; // Variable estática para almacenar la etiqueta del botón seleccionado
    }

}
