using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mapScript : MonoBehaviour
{
    public string className;
    public string topicName;


    //class - n, p, l, u
    //topic - colors, 
    
    public GameObject webViewGameobject;
    public WebView webviewInstance;
    public Text statusForWebview;
    public GameObject webPageCanvas;
    public GameObject mapGameobject;
    public GameObject[] nodesCompleted;
    public string[] linksToGame;

    private int activeGame;
    void Start()
    {
        mapGameobject.SetActive(true);
        webPageCanvas.SetActive(false);
        webViewGameobject.SetActive(false);
        for(int i=1; i <= nodesCompleted.Length; i++)
        {
            if (PlayerPrefs.GetInt(className + "-" + topicName + "-" + i, 0) != 0)
            {
                nodesCompleted[i-1].SetActive(true);
            }
            else
            {
                nodesCompleted[i-1].SetActive(false);
            }
        }
    }
    private void Update()
    {
        
    }

    public void nodeClick(int nodeNumber)
    {
        activeGame = nodeNumber;
        mapGameobject.SetActive(false);
        webPageCanvas.SetActive(true);
        webViewGameobject.SetActive(true);
        StartCoroutine(webviewInstance.LoadPage(linksToGame[nodeNumber], statusForWebview));
    }
    
    public void MarkAsUnread()
    {
        mapGameobject.SetActive(true);
        webPageCanvas.SetActive(false);
        webViewGameobject.SetActive(false);
        
        var g = GameObject.Find("WebViewObject");
        if (g != null)
        {
            Destroy(g);
        }
        PlayerPrefs.SetInt(className + "-" + topicName + "-" + (activeGame + 1), 0);
        nodesCompleted[activeGame].SetActive(false);
        activeGame = -1;
    }

    public void proceedButton()
    {
        nodesCompleted[activeGame].SetActive(true);
        mapGameobject.SetActive(true);
        webPageCanvas.SetActive(false);
        webViewGameobject.SetActive(false);
        
        var g = GameObject.Find("WebViewObject");
        if (g != null)
        {
            Destroy(g);
        }
        PlayerPrefs.SetInt(className + "-" + topicName + "-" + (activeGame + 1), 1);
        activeGame = -1;
    }

    public void loadMainMenu()
    {
        SceneManager.LoadScene("Levels");
    }
}
