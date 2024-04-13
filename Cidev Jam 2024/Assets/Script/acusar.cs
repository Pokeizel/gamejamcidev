using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class acusar : MonoBehaviour
{

    public Button yourButton;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(() =>
        {
            isTrueInnocet();
        });
    }

    // Update is called once per frame
    public void isTrueInnocet(){

        if (yourButton.gameObject.tag == "guilty") {

            Debug.Log("fuiste vos rata");

        }
        if (yourButton.gameObject.tag == "innocent") 
        {
            Debug.Log("sad por ti");
        }


        }
}
