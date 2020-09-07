using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level_Interaction : MonoBehaviour
{
    //Game objects
    public GameObject welcomeText;
    public GameObject playgroupBoard;
    public GameObject nurseryBoard;
    public GameObject lkgBoard;
    public GameObject ukgBoard;
    public GameObject progrssPannel;

    //public GameObject[] levelMenu;
    [Header("Level Menu Items")]
    public GameObject playgroupMenu;
    public GameObject nurseryMenu;
    public GameObject lkgMenu;
    public GameObject ukgMenu;

    //sound-related
    public AudioSource sound;
    void Start()
    {
        welcomeText.SetActive(true);
        playgroupBoard.SetActive(false);
        nurseryBoard.SetActive(false);
        lkgBoard.SetActive(false);
        ukgBoard.SetActive(false);
        progrssPannel.SetActive(false);

/*        playgroupMenu.SetActive(false);
        nurseryMenu.SetActive(false);
        lkgMenu.SetActive(false);
        ukgMenu.SetActive(false);



        switch (PlayerPrefs.GetString("level").ToLower())
        {
            case "playgroup":
                playgroupMenu.SetActive(true);
                break;
            case "nursery":
                nurseryMenu.SetActive(true);
                break;
            case "lkg":
                lkgMenu.SetActive(true);
                break;
            case "ukg":
                ukgMenu.SetActive(true);
                return;
            default:
                SceneManager.LoadScene("loginMenu");
                break;

        }*/
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
        PlayerPrefs.SetString("class", "p");
    }

    public void nurseryButton()
    {
        sound.Play();
        welcomeText.SetActive(false);
        
        playgroupBoard.SetActive(false);
        nurseryBoard.SetActive(true);
        lkgBoard.SetActive(false);
        ukgBoard.SetActive(false);
        PlayerPrefs.SetString("class", "n");
    }
    public void lkgButton()
    {
        sound.Play();
        welcomeText.SetActive(false);
        playgroupBoard.SetActive(false);
        nurseryBoard.SetActive(false);
        lkgBoard.SetActive(true);
        ukgBoard.SetActive(false);
        PlayerPrefs.SetString("class", "l");
    }
    public void ukgButton()
    {
        sound.Play();
        welcomeText.SetActive(false);
        playgroupBoard.SetActive(false);
        nurseryBoard.SetActive(false);
        lkgBoard.SetActive(false);
        ukgBoard.SetActive(true);
        PlayerPrefs.SetString("class", "u");
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
