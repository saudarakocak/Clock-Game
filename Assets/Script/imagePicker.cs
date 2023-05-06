using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using TMPro;

public class imagePicker : MonoBehaviour
{
    string Finalpath;
    public RawImage image;

    public void LoadFile()
    {
        string fileType = NativeFilePicker.ConvertExtensionToFileType("jpg");

        NativeFilePicker.Permission permission = NativeFilePicker.PickFile((path) =>
        {
            if (path == null)
            {
                Debug.Log("Operation cancelled");
            }
            else
            {
                
                Finalpath = path;
                Debug.Log("Picked file: " + Finalpath);
                StartCoroutine("LoadTexture");
            }
        }, new string[] { fileType });
    }
    
    IEnumerator LoadTexture()
    {
        WWW www = new WWW("file:///" + Finalpath);
        while (!www.isDone)
        {
            yield return null;
            image.texture = www.texture;
        }
    }
}
