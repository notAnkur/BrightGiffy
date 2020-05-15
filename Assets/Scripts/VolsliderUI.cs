using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolsliderUI : MonoBehaviour
{
    public GameObject slider;
    public bool isActive = false;
  public void onAndoff()
    {
        if (isActive)
            isActive = false;
        else isActive = true;

        slider.SetActive(isActive);
    }
}
