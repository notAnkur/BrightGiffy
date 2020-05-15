using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveProgress : MonoBehaviour
{
    public int nodes_p_shapes;
    public int nodes_p_colors;
    public int nodes_p_fruits;
    public int nodes_p_vegetables;
    public int nodes_p_farmAnimals;
    public int nodes_p_jungleAnimals;
    public int nodes_p_transportation;

    
    void Start()
    {
        if (PlayerPrefs.GetInt("firstLoad", 0) == 0)
        {
            PlayerPrefs.SetInt("firstLoad", 1);
            Debug.Log("xxooxx");
            for (int i = 1; i <= nodes_p_shapes; i++) PlayerPrefs.SetInt("p-shapes-" + i, 0);
            for (int i = 1; i <= nodes_p_colors; i++) PlayerPrefs.SetInt("p-colors-" + i, 0);
            for (int i = 1; i <= nodes_p_fruits; i++) PlayerPrefs.SetInt("p-fruits-" + i, 0);
            for (int i = 1; i <= nodes_p_vegetables; i++) PlayerPrefs.SetInt("p-vegetables-" + i, 0);
            for (int i = 1; i <= nodes_p_farmAnimals; i++) PlayerPrefs.SetInt("p-farmAnimals-" + i, 0);
            for (int i = 1; i <= nodes_p_jungleAnimals; i++) PlayerPrefs.SetInt("p-jungleAnimals-" + i, 0);
            for (int i = 1; i <= nodes_p_transportation; i++) PlayerPrefs.SetInt("p-transportation-" + i, 0);
        }

    }

    void Update()
    {
        
    }
}
