using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wallpaperManagement : MonoBehaviour
{
    public RawImage wallpaper;
    int patokan;
    public Texture[] imageCollection;
    public GameObject[] chosedImage;
    public restUI rest;

    private void Update()
    {
        if (patokan <= 15)
        {
            wallpaper.texture = imageCollection[patokan];
        }
        //chosed
        chosedImage[patokan].gameObject.SetActive(true);
    }

    void allOffChosed()
    {
        for (int i = 0; i < chosedImage.Length; i++)
        {
            chosedImage[i].gameObject.SetActive(false);
        }
    }

    public void contentButton(int x)
    {
        rest.ClosedIt();
        allOffChosed();
        patokan = x;
    }
}
