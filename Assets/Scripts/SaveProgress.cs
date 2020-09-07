using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveProgress : MonoBehaviour
{

    //============================================== Number of nodes ==============================================
    [Header("Nodes")]
    public int nodes_p_shapes;
    public int nodes_p_colors;
    public int nodes_p_fruits;
    public int nodes_p_vegetables;
    public int nodes_p_farmanimals;
    public int nodes_p_jungleanimals;
    public int nodes_p_transportation;
    public int nodes_p_numbers;

    public int nodes_n_shapes;
    public int nodes_n_colors;
    public int nodes_n_fruits;
    public int nodes_n_vegetables;
    public int nodes_n_farmanimals;
    public int nodes_n_jungleanimals;
    public int nodes_n_transportation;
    public int nodes_n_numbers;

    public int nodes_l_shapes;
    public int nodes_l_colors;
    public int nodes_l_fruits;
    public int nodes_l_vegetables;
    public int nodes_l_farmanimals;
    public int nodes_l_jungleanimals;
    public int nodes_l_transportation;
    public int nodes_l_numbers;
    public int nodes_l_communityhelpers;

    public int nodes_u_shapes;
    public int nodes_u_colors;
    public int nodes_u_fruits;
    public int nodes_u_vegetables;
    public int nodes_u_farmanimals;
    public int nodes_u_jungleanimals;
    public int nodes_u_transportation;
    public int nodes_u_numbers;
    public int nodes_u_communityhelpers;
    public int nodes_u_places;

    //============================================== % Display ==============================================
    [Header("Percentage Display")]
    public Text percnt_p_shapes;
    public Text percnt_p_colors;
    public Text percnt_p_fruits;
    public Text percnt_p_vegetables;
    public Text percnt_p_farmanimals;
    public Text percnt_p_jungleanimals;
    public Text percnt_p_transportation;
    public Text percnt_p_numbers;

    public Text percnt_n_shapes;
    public Text percnt_n_colors;
    public Text percnt_n_fruits;
    public Text percnt_n_vegetables;
    public Text percnt_n_farmanimals;
    public Text percnt_n_jungleanimals;
    public Text percnt_n_transportation;
    public Text percnt_n_numbers;

    public Text percnt_l_shapes;
    public Text percnt_l_colors;
    public Text percnt_l_fruits;
    public Text percnt_l_vegetables;
    public Text percnt_l_farmanimals;
    public Text percnt_l_jungleanimals;
    public Text percnt_l_transportation;
    public Text percnt_l_numbers;
    public Text percnt_l_communityhelpers;

    public Text percnt_u_shapes;
    public Text percnt_u_colors;
    public Text percnt_u_fruits;
    public Text percnt_u_vegetables;
    public Text percnt_u_farmanimals;
    public Text percnt_u_jungleanimals;
    public Text percnt_u_transportation;
    public Text percnt_u_numbers;
    public Text percnt_u_communityhelpers;
    public Text percnt_u_places;

    //============================================== Bar Display ==============================================
    [Header("Bar Display")]
    public Image bar_p_shapes;
    public Image bar_p_colors;
    public Image bar_p_fruits;
    public Image bar_p_vegetables;
    public Image bar_p_farmanimals;
    public Image bar_p_jungleanimals;
    public Image bar_p_transportation;
    public Image bar_p_numbers;

    public Image bar_n_shapes;
    public Image bar_n_colors;
    public Image bar_n_fruits;
    public Image bar_n_vegetables;
    public Image bar_n_farmanimals;
    public Image bar_n_jungleanimals;
    public Image bar_n_transportation;
    public Image bar_n_numbers;

    public Image bar_l_shapes;
    public Image bar_l_colors;
    public Image bar_l_fruits;
    public Image bar_l_vegetables;
    public Image bar_l_farmanimals;
    public Image bar_l_jungleanimals;
    public Image bar_l_transportation;
    public Image bar_l_numbers;
    public Image bar_l_communityhelpers;

    public Image bar_u_shapes;
    public Image bar_u_colors;
    public Image bar_u_fruits;
    public Image bar_u_vegetables;
    public Image bar_u_farmanimals;
    public Image bar_u_jungleanimals;
    public Image bar_u_transportation;
    public Image bar_u_numbers;
    public Image bar_u_communityhelpers;
    public Image bar_u_places;

    //============================================== summation of the completed topics-class ==============================================
    private float sum_p_shapes = 0;
    private float sum_p_colors = 0;
    private float sum_p_fruits = 0;
    private float sum_p_vegetables = 0;
    private float sum_p_farmanimals = 0;
    private float sum_p_jungleanimals = 0;
    private float sum_p_transportation = 0;
    private float sum_p_numbers = 0;

    private float sum_n_shapes = 0;
    private float sum_n_colors = 0;
    private float sum_n_fruits = 0;
    private float sum_n_vegetables = 0;
    private float sum_n_farmanimals = 0;
    private float sum_n_jungleanimals = 0;
    private float sum_n_transportation = 0;
    private float sum_n_numbers = 0;

    private float sum_l_shapes = 0;
    private float sum_l_colors = 0;
    private float sum_l_fruits = 0;
    private float sum_l_vegetables = 0;
    private float sum_l_farmanimals = 0;
    private float sum_l_jungleanimals = 0;
    private float sum_l_transportation = 0;
    private float sum_l_numbers = 0;
    private float sum_l_communityhelpers = 0;

    private float sum_u_shapes = 0;
    private float sum_u_colors = 0;
    private float sum_u_fruits = 0;
    private float sum_u_vegetables = 0;
    private float sum_u_farmanimals = 0;
    private float sum_u_jungleanimals = 0;
    private float sum_u_transportation = 0;
    private float sum_u_numbers = 0;
    private float sum_u_communityhelpers = 0;
    private float sum_u_places = 0;
    private string[] classes = { "" };

    void Start()
    {
        if (PlayerPrefs.GetInt("firstLoad", 0) == 0)
        {
            PlayerPrefs.SetInt("firstLoad", 1);
            {

            }
        }



        percnt_p_shapes.text = ((sum_p_shapes / nodes_p_shapes) * 100).ToString("F0") + "%";
        percnt_p_colors.text = ((sum_p_colors / nodes_p_colors) * 100).ToString("F0") + "%";
        percnt_p_fruits.text = ((sum_p_fruits / nodes_p_fruits) * 100).ToString("F0") + "%";
        percnt_p_vegetables.text = ((sum_p_vegetables / nodes_p_vegetables) * 100).ToString("F0") + "%";
        percnt_p_farmanimals.text = ((sum_p_farmanimals / nodes_p_farmanimals) * 100).ToString("F0") + "%";
        percnt_p_jungleanimals.text = ((sum_p_jungleanimals / nodes_p_jungleanimals) * 100).ToString("F0") + "%";
        percnt_p_transportation.text = ((sum_p_transportation / nodes_p_transportation) * 100).ToString("F0") + "%";


        bar_p_shapes.fillAmount = (sum_p_shapes / nodes_p_shapes);
        bar_p_colors.fillAmount = (sum_p_colors / nodes_p_colors);
        bar_p_fruits.fillAmount = (sum_p_fruits / nodes_p_fruits);
        bar_p_vegetables.fillAmount = (sum_p_vegetables / nodes_p_vegetables);
        bar_p_farmanimals.fillAmount = (sum_p_farmanimals / nodes_p_farmanimals);
        bar_p_jungleanimals.fillAmount = (sum_p_jungleanimals / nodes_p_jungleanimals);
        bar_p_transportation.fillAmount = (sum_p_transportation / nodes_p_transportation);

    }

    void Update()
    {
        
    }

    public void ProgresSet(string classs)
    {
        for (int i = 1; i <= nodes_p_shapes; i++) sum_p_shapes += PlayerPrefs.GetInt("p-shapes-" + i, 0);
        for (int i = 1; i <= nodes_p_colors; i++) sum_p_colors += PlayerPrefs.GetInt("p-colors-" + i, 0);
        for (int i = 1; i <= nodes_p_fruits; i++) sum_p_fruits += PlayerPrefs.GetInt("p-fruits-" + i, 0);
        for (int i = 1; i <= nodes_p_vegetables; i++) sum_p_vegetables += PlayerPrefs.GetInt("p-vegetables-" + i, 0);
        for (int i = 1; i <= nodes_p_farmanimals; i++) sum_p_farmanimals += PlayerPrefs.GetInt("p-farmanimals-" + i, 0);
        for (int i = 1; i <= nodes_p_jungleanimals; i++) sum_p_jungleanimals += PlayerPrefs.GetInt("p-jungleanimals-" + i, 0);
        for (int i = 1; i <= nodes_p_transportation; i++) sum_p_transportation += PlayerPrefs.GetInt("p-transportation-" + i, 0);

    }
}
