using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mapHandler : MonoBehaviour
{
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
        foreach (GameObject node in nodesCompleted)
        {
            node.SetActive(false);
        }
    }

    public void nodeClick(int nodeNumber)
    {
        activeGame = nodeNumber;
        mapGameobject.SetActive(false);
        webPageCanvas.SetActive(true);
        webViewGameobject.SetActive(true);
        StartCoroutine(webviewInstance.LoadPage(linksToGame[nodeNumber], statusForWebview));
        //Debug.Log(linksToGame[nodeNumber]);
    }

    public void MarkAsUnread()
    {
        nodesCompleted[activeGame].SetActive(false);
        mapGameobject.SetActive(true);
        webPageCanvas.SetActive(false);
        webViewGameobject.SetActive(false);
        activeGame = -1;
        var g = GameObject.Find("WebViewObject");
        if (g != null)
        {
            Destroy(g);
        }
    }

    public void proceedButton()
    {
        nodesCompleted[activeGame].SetActive(true);
        mapGameobject.SetActive(true);
        webPageCanvas.SetActive(false);
        webViewGameobject.SetActive(false);
        activeGame = -1;
        var g = GameObject.Find("WebViewObject");
        if (g != null)
        {
            Destroy(g);
        }
    }

    public void loadMainMenu()
    {
        SceneManager.LoadScene("Levels");
    }
}
