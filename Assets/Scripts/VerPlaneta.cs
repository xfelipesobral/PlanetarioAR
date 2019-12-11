using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VerPlaneta : MonoBehaviour
{
    public void abrirPlaneta(string planetaNome)
    {
        SceneManager.LoadScene(planetaNome);
    }

    public void velocidade()
    {
        GameObject SliderGet;

        SliderGet = GameObject.Find("Slider");
        Time.timeScale = SliderGet.GetComponent<Slider>().value;
    }
}

