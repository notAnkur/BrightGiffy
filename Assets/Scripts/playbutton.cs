using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(Button))]
public class playbutton : MonoBehaviour
{
    public Button yourButton;
    public AudioClip sound;
    private AudioSource bclicksound { get { return GetComponent<AudioSource>(); } }

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(jaclick);
        gameObject.AddComponent<AudioSource>();
        bclicksound.clip = sound;
        bclicksound.playOnAwake = false;
    }

    public void jaclick()
    {
        bclicksound.PlayOneShot(sound);
        StartCoroutine(DelaySceneLoad());
    }
    IEnumerator DelaySceneLoad()
    {
        yield return new WaitForSeconds(0.01f);
        SceneManager.LoadScene("Levels");
    }
}
