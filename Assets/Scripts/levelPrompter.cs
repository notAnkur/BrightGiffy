using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelPrompter : MonoBehaviour
{
    public Text promptMessage;
    public GameObject darkScreen;
    public GameObject promptPanel;
    private static string activePromptLevel;

    public static bool isPrompterOn = false;

    private void Start()
    {
        darkScreen.SetActive(false);
        promptPanel.SetActive(false);
    }

    public void turnOnPrompter(string a)
    {
        activePromptLevel = "_" + a.ToLower();
        if (!isPrompterOn)
        {
            promptPanel.SetActive(true);
            promptMessage.text = a + "?";
            darkScreen.SetActive(true);
            isPrompterOn = true;
        }
    }

    public void turnOffPrompter()
    {
        promptPanel.SetActive(false);
        darkScreen.SetActive(false);
        isPrompterOn = false;
    }

    public void proceedWithLevel()
    {
        Debug.Log("GG This is here doing");
        SceneManager.LoadScene(activePromptLevel);
        isPrompterOn = false;
    }
}
