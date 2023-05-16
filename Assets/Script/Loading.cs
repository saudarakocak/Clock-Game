using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    float loadingStart = 0;
    public Slider slider;
    public detectClock clock;
    public GameObject transisi;
    void Start()
    {
        slider.maxValue = 10;
    }

    // Update is called once per frame
    void Update()
    {
        loadingStart += Time.deltaTime * 2;
        slider.value = loadingStart;
        if (loadingStart >= 10)
        {
            transisi.gameObject.SetActive(true);
            Invoke("pindahScene", 1);
        }
    }

    void pindahScene()
    {
        if (clock.IsClock)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
