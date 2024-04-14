using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
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
        instance = this;
        if (instance == null) {
            instance = this;
        } else if (instance != this) {
            Destroy(this);
        }
        DontDestroyOnLoad(this);
    }
    void Start()
    {

        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
