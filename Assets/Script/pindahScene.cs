using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pindahScene : MonoBehaviour
{
    public void pindah()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void hancur()
    {
        gameObject.SetActive(false);
    }
}
