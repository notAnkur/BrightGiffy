using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level_Interaction : MonoBehaviour
{
    //Game objects
    public GameObject welcomeText;
    public GameObject playgroup;

    //sound-related
    public AudioClip sound;
    private AudioSource bclicksound { get { return GetComponent<AudioSource>(); } }
    void Start()
    {
        playgroup.AddComponent<AudioSource>();
        Time.timeScale = 1;
        welcomeText.SetActive(true);
        playgroup.SetActive(false);
    }

    void Update()
    {
        
    }

    public void playgroupButton()
    {
        bclicksound.PlayOneShot(sound);
        welcomeText.SetActive(false);
        playgroup.SetActive(true);
    }
    public void mainMenuButton()
    {
        bclicksound.PlayOneShot(sound);
        welcomeText.SetActive(true);
        playgroup.SetActive(false);
    }
}
