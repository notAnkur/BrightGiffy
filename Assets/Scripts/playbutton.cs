using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class playbutton : MonoBehaviour
{

    public AudioSource sound;
    public InputField email, password;
    public GameObject WarningContainer;
    public Text WarningLabel;

    public GameObject LoginContainer, PersistentLogin;
    public Text PersistentLoginLabel;

    void Start()
    {
        PersistentLoginLabel.text = "Authenticating...";
        if(string.IsNullOrEmpty(PlayerPrefs.GetString("token", null)))
        {
            // no token, make user login
            PersistentLogin.SetActive(false);
            LoginContainer.SetActive(true);
        } else
        {
            LoadMainMenu();
        }
    }

    public void LoadMainMenu()
    {
        sound.Play();
        SceneManager.LoadSceneAsync("Levels");
    }
    public void LoadLoginMenu()
    {
        sound.Play();
        SceneManager.LoadScene("loginMenu");
    }

    public void LoginButton()
    {
        Debug.Log(email.text + " " + password.text);
        StartCoroutine(new Authentication().LogIn(email.text, password.text, (isNetworkError, response) => {
            Debug.Log(isNetworkError);
            if (isNetworkError)
            {
                //animate and display msg
                DisplayAuthError("Network error. Try again.");
            }
            else
            {
                AuthResponse authResponse = (AuthResponse)JsonUtility.FromJson(response.ToString(), typeof(AuthResponse));
                Debug.Log(response);
                Debug.Log(authResponse.userProfile.displayName);
                if (authResponse.isSuccess)
                {
                    // credentials were correct, save token and userprofile to playerfrefs and switch scenes
                    PlayerPrefs.SetString("token", authResponse.token);
                    PlayerPrefs.SetString("displayName", authResponse.userProfile.displayName);
                    PlayerPrefs.SetString("email", authResponse.userProfile.email);
                    PlayerPrefs.SetString("photoURL", authResponse.userProfile.photoURL);
                    PlayerPrefs.SetString("level", authResponse.userProfile.level);

                    LoadMainMenu();
                }
                else
                {
                    DisplayAuthError(authResponse.message);
                }
            }
        }));
    }

    IEnumerator HideAuthInfo(GameObject containerObject)
    {
        yield return new WaitForSeconds(4.0f);
        containerObject.SetActive(false);
    }

    private void DisplayAuthError(string authResponseMessage)
    {
        WarningContainer.SetActive(true);
        WarningLabel.text = authResponseMessage.ToString();
        WarningContainer.GetComponent<Animator>().Play("authInfo");
        StartCoroutine(HideAuthInfo(WarningContainer));
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