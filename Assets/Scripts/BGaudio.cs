using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGaudio : MonoBehaviour
{
    private static BGaudio instance = null;
    AudioSource bgmAudio;
    public static BGaudio Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);

        bgmAudio = this.GetComponent<AudioSource>();
    }
    private void Update()
    {
        if(SceneManager.GetActiveScene().name != "MainMenu" && SceneManager.GetActiveScene().name != "Levels")
        {
            bgmAudio.volume = 0.375f;
        }
        else
        {
            bgmAudio.volume = 0.75f;
        }
    }
}
