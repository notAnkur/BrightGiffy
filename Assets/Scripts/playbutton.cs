using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Text.RegularExpressions;
using System;

public class playbutton : MonoBehaviour
{
    public AudioSource sound;
    public InputField email, password;
    public GameObject AuthInfoContainer;
    public Text AuthInfoLabel;

    public const string EmailPattern =
        @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
        + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
        + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
        + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";

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

    public void LoginButton()
    {
        if (ValidateEmail(email.text))
        {
            Debug.Log(email.text + " " + password.text);
            StartCoroutine(new Authentication().LogIn(email.text, password.text, (isNetworkError, response) => {
                Debug.Log(isNetworkError);
                if(isNetworkError)
                {
                    //animate and display msg
                } else
                {
                    AuthResponse authResponse = (AuthResponse)JsonUtility.FromJson(response.ToString(), typeof(AuthResponse));
                    Debug.Log(response);
                    Debug.Log(authResponse.userProfile.displayName);
                    if(authResponse.isSuccess)
                    {
                        // credentials were correct, switch scenes
                        LoadMainMenu();
                    } else
                    {
                        DisplayAuthError(authResponse);
                    }
                }
            }));
        } else
        {
            Debug.Log("Email format not valid");
        }
    }

    IEnumerator HideAuthInfo(GameObject containerObject)
    {
        yield return new WaitForSeconds(4.0f);
        containerObject.SetActive(false);
    }

    private void DisplayAuthError(AuthResponse authResponse)
    {
        AuthInfoContainer.SetActive(true);
        AuthInfoLabel.text = authResponse.message.ToString();
        AuthInfoContainer.GetComponent<Animator>().Play("authInfo");
        StartCoroutine(HideAuthInfo(AuthInfoContainer));
    }

    private bool ValidateEmail(string email)
    {
        if (email != null) return Regex.IsMatch(email, EmailPattern);
        else return false;
    }
}

[System.Serializable]
public class AuthResponse
{
    public string token;
    public bool isSuccess;
    public string message;
    public UserProfile userProfile;
}

[System.Serializable]
public class UserProfile
{
    public string email;
    public string displayName;
    public string photoURL;
    public string level;
}