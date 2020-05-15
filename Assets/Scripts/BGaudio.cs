using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGaudio : MonoBehaviour
{
    private static BGaudio instance = null;
    public static BGaudio Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);
    }
}
