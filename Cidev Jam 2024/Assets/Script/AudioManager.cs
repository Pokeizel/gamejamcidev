using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    private bool isInIntro = false;
    public AudioClip introClip;
    public AudioClip gameClip;
    public AudioClip acusarClip;
    // Start is called before the first frame update
    private static AudioManager instance;
    public static AudioManager Instance {
        get{
           if (instance == null) {
                Debug.LogError("Audio Manager is null");
           } 
           return instance;
        }
    }
    void Awake() {
        //instance = this;
        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(this);
        } else if (instance != this) {
            Destroy(this);
        }
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name == "Inicio" && !isInIntro)
        {
            isInIntro = true;
            audioSource.Stop();
            audioSource.clip = introClip;
            audioSource.Play();
        }
        
    }
    public void PlayGameMusic()
    {
            isInIntro = false;
            audioSource.Stop();
            audioSource.clip = gameClip;
            audioSource.Play();
    }

    public void PlayAcusarMusic()
    {
        isInIntro = false;
            audioSource.Stop();
            audioSource.clip = acusarClip;
            audioSource.Play();
    }
}