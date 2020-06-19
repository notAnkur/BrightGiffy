using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level_Interaction : MonoBehaviour
{
    //Game objects
    public GameObject welcomeText;
    public GameObject playgroupBoard;
    public GameObject nurseryBoard;
    public GameObject lkgBoard;
    public GameObject ukgBoard;
    public GameObject progrssPannel;

    //sound-related
    public AudioSource sound;
    void Start()
    {
        welcomeText.SetActive(true);
        playgroupBoard.SetActive(false);
        playgroupBoard.SetActive(false);
        nurseryBoard.SetActive(false);
        lkgBoard.SetActive(false);
        ukgBoard.SetActive(false);
        progrssPannel.SetActive(false);
    }

    void Update()
    {
        
    }
    public void mainMenuButton()
    {
        sound.Play();
        welcomeText.SetActive(true);
        playgroupBoard.SetActive(false);
        nurseryBoard.SetActive(false);
        lkgBoard.SetActive(false);
        ukgBoard.SetActive(false);
    }

    public void playgroupButton()
    {
        sound.Play();
        welcomeText.SetActive(false);
        playgroupBoard.SetActive(true);
        nurseryBoard.SetActive(false);
        lkgBoard.SetActive(false);
        ukgBoard.SetActive(false);
    }

    public void nurseryButton()
    {
        sound.Play();
        welcomeText.SetActive(false);
        
        playgroupBoard.SetActive(false);
        nurseryBoard.SetActive(true);
        lkgBoard.SetActive(false);
        ukgBoard.SetActive(false);
    }
    public void lkgButton()
    {
        sound.Play();
        welcomeText.SetActive(false);
        playgroupBoard.SetActive(false);
        nurseryBoard.SetActive(false);
        lkgBoard.SetActive(true);
        ukgBoard.SetActive(false);
    }
    public void ukgButton()
    {
        sound.Play();
        welcomeText.SetActive(false);
        playgroupBoard.SetActive(false);
        nurseryBoard.SetActive(false);
        lkgBoard.SetActive(false);
        ukgBoard.SetActive(true);
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
