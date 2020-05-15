using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class BGvolumesetter : MonoBehaviour
{
    public AudioMixer audmix;
    public void Start()
    {
        audmix.SetFloat("BGvolumeval", 1);
    }
    public void Volume(float sliderval)
    {
        audmix.SetFloat("BGvolumeval", Mathf.Log10(sliderval)*30);
    }
}
