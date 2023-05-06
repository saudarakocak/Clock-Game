using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicManagement : MonoBehaviour
{
    public int patokan;
    public GameObject[] chosedImage;
    public restUI rest;

    private void Start()
    {
        allOffChosed();
    }

    private void Update()
    {
        chosedImage[patokan].gameObject.SetActive(true);
    }

    


    void allOffChosed()
    {
        for (int i = 0; i < chosedImage.Length; i++)
        {
            chosedImage[i].gameObject.SetActive(false);
        }
    }

    public void MusicChosen(int x)
    {
        FindObjectOfType<AudioManager>().stopAll();
        rest.ClosedIt();
        allOffChosed();
        patokan = x;


        switch (patokan)
        {
            case 0:
                FindObjectOfType<AudioManager>().stopAll();
                Debug.Log("music mati");
                break;
            case 1:
                FindObjectOfType<AudioManager>().Play("audio_1");
                Debug.Log("music 1");
                break;
            case 2:
                FindObjectOfType<AudioManager>().Play("audio_2");
                Debug.Log("music 2");
                break;
            case 3:
                FindObjectOfType<AudioManager>().Play("audio_3");
                Debug.Log("music 3");
                break;
            case 4:
                FindObjectOfType<AudioManager>().Play("audio_4");
                Debug.Log("music 4");
                break;
            case 5:
                FindObjectOfType<AudioManager>().Play("audio_5");
                Debug.Log("music 5");
                break;
        }
    }
}
