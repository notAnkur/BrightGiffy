using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level_Interaction : MonoBehaviour
{
    //Game objects
    public GameObject welcomeText;
    public GameObject playgroup;
    public GameObject progrssPannel;

    //sound-related
    public AudioSource sound;
    void Start()
    {
        welcomeText.SetActive(true);
        playgroup.SetActive(false);
        progrssPannel.SetActive(false);
    }

    void Update()
    {
        
    }

    public void playgroupButton()
    {
        sound.Play();
        welcomeText.SetActive(false);
        playgroup.SetActive(true);
    }
    public void mainMenuButton()
    {
        sound.Play();
        welcomeText.SetActive(true);
        playgroup.SetActive(false);
    }

    public void progressOpen()
    {
        sound.Play();
        progrssPannel.SetActive(true);
    }
    public void closeProgress()
    {
        sound.Play();
        progrssPannel.SetActive(false);
    }
}
