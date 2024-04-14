using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InicioScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject popup;
    public void Play()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        AudioManager.Instance.PlayGameMusic();

    }

    public void Exit()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; //Sale del modo Play en el editor de Unity
#endif
    }
    // Update is called once per frame


    public void OutPopUp()
    {

        popup.SetActive(true);
       
    }

    public void BackPopUp()
    {

        popup.SetActive(false);

    }
    void Update()
    {
        
    }
}
