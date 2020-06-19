using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class playbutton : MonoBehaviour
{

    public AudioSource sound;

    void Start()
    {

    }

    public void LoadMainMenu()
    {
        sound.Play();
        SceneManager.LoadScene("Levels");
    }
    public void LoadLoginMenu(string a)
    {
        sound.Play();
        SceneManager.LoadScene(a);
    }
}
