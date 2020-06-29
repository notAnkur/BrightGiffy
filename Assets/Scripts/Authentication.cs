using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Authentication
{
    private static string requestUrl = "http://ec2-54-89-182-73.compute-1.amazonaws.com:8006/auth/login";

    /*
    *   callback params -> (bool isNetworkError, string network_response)
    */
    public IEnumerator LogIn(string email, string password, System.Action<bool, string> callback)
    {
        Debug.Log("ping");
        WWWForm loginForm = new WWWForm();
        loginForm.AddField("email", email);
        loginForm.AddField("password", password);

        UnityWebRequest uwr = UnityWebRequest.Post(requestUrl, loginForm);
        yield return uwr.SendWebRequest();

        if(uwr.isNetworkError)
        {
            callback(true, uwr.error);
        } else
        {
            callback(false, uwr.downloadHandler.text);
        }
    }
}
