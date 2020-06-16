using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveProgress : MonoBehaviour
{
    [Header("Nodes")]
    public int nodes_p_shapes;
    public int nodes_p_colors;
    public int nodes_p_fruits;
    public int nodes_p_vegetables;
    public int nodes_p_farmAnimals;
    public int nodes_p_jungleAnimals;
    public int nodes_p_transportation;
    
    [Header("Percentage Display")]
    public Text percnt_p_shapes;
    public Text percnt_p_colors;
    public Text percnt_p_fruits;
    public Text percnt_p_vegetables;
    public Text percnt_p_farmAnimals;
    public Text percnt_p_jungleAnimals;
    public Text percnt_p_transportation;

    [Header("Bar Display")]
    public Image bar_p_shapes;
    public Image bar_p_colors;
    public Image bar_p_fruits;
    public Image bar_p_vegetables;
    public Image bar_p_farmAnimals;
    public Image bar_p_jungleAnimals;
    public Image bar_p_transportation;

    private float sum_p_shapes = 0;
    private float sum_p_colors = 0;
    private float sum_p_fruits = 0;
    private float sum_p_vegetables = 0;
    private float sum_p_farmAnimals = 0;
    private float sum_p_jungleAnimals = 0;
    private float sum_p_transportation = 0;




    void Start()
    {
        if (PlayerPrefs.GetInt("firstLoad", 0) == 0)
        {
            PlayerPrefs.SetInt("firstLoad", 1);
            for (int i = 1; i <= nodes_p_shapes; i++) PlayerPrefs.SetInt("p-shapes-" + i, 0);
            for (int i = 1; i <= nodes_p_colors; i++) PlayerPrefs.SetInt("p-colors-" + i, 0);
            for (int i = 1; i <= nodes_p_fruits; i++) PlayerPrefs.SetInt("p-fruits-" + i, 0);
            for (int i = 1; i <= nodes_p_vegetables; i++) PlayerPrefs.SetInt("p-vegetables-" + i, 0);
            for (int i = 1; i <= nodes_p_farmAnimals; i++) PlayerPrefs.SetInt("p-farmAnimals-" + i, 0);
            for (int i = 1; i <= nodes_p_jungleAnimals; i++) PlayerPrefs.SetInt("p-jungleAnimals-" + i, 0);
            for (int i = 1; i <= nodes_p_transportation; i++) PlayerPrefs.SetInt("p-transportation-" + i, 0);
        }

        for (int i = 1; i <= nodes_p_shapes; i++)
        {
            sum_p_shapes += PlayerPrefs.GetInt("p-shapes-" + i, 0);
        }
        for (int i = 1; i <= nodes_p_colors; i++)
        {
            sum_p_colors += PlayerPrefs.GetInt("p-colors-" + i, 0);
        }
        for (int i = 1; i <= nodes_p_fruits; i++)
        {
            sum_p_fruits += PlayerPrefs.GetInt("p-fruits-" + i, 0);
        }
        for (int i = 1; i <= nodes_p_vegetables; i++)
        {
            sum_p_vegetables += PlayerPrefs.GetInt("p-vegetables-" + i, 0);
        }
        for (int i = 1; i <= nodes_p_farmAnimals; i++)
        {
            sum_p_farmAnimals += PlayerPrefs.GetInt("p-farmAnimals-" + i, 0);
        }
        for (int i = 1; i <= nodes_p_jungleAnimals; i++)
        {
            sum_p_jungleAnimals += PlayerPrefs.GetInt("p-jungleAnimals-" + i, 0);
        }
        for (int i = 1; i <= nodes_p_transportation; i++)
        {
            sum_p_transportation += PlayerPrefs.GetInt("p-transportation-" + i, 0);
        }

        percnt_p_shapes.text = ((sum_p_shapes / nodes_p_shapes) * 100).ToString("F0") + "%";
        percnt_p_colors.text = ((sum_p_colors / nodes_p_colors) * 100).ToString("F0") + "%";
        percnt_p_fruits.text = ((sum_p_fruits / nodes_p_fruits) * 100).ToString("F0") + "%";
        percnt_p_vegetables.text = ((sum_p_vegetables / nodes_p_vegetables) * 100).ToString("F0") + "%";
        percnt_p_farmAnimals.text = ((sum_p_farmAnimals / nodes_p_farmAnimals) * 100).ToString("F0") + "%";
        percnt_p_jungleAnimals.text = ((sum_p_jungleAnimals / nodes_p_jungleAnimals) * 100).ToString("F0") + "%";
        percnt_p_transportation.text = ((sum_p_transportation / nodes_p_transportation) * 100).ToString("F0") + "%";


        bar_p_shapes.fillAmount = (sum_p_shapes / nodes_p_shapes);
        bar_p_colors.fillAmount = (sum_p_colors / nodes_p_colors);
        bar_p_fruits.fillAmount = (sum_p_fruits / nodes_p_fruits);
        bar_p_vegetables.fillAmount = (sum_p_vegetables / nodes_p_vegetables);
        bar_p_farmAnimals.fillAmount = (sum_p_farmAnimals / nodes_p_farmAnimals);
        bar_p_jungleAnimals.fillAmount = (sum_p_jungleAnimals / nodes_p_jungleAnimals);
        bar_p_transportation.fillAmount = (sum_p_transportation / nodes_p_transportation);

    }

    void Update()
    {
        
    }
}
