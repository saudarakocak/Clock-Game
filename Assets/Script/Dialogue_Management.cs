using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dialogue_Management : MonoBehaviour
{
    public TMP_Text dialogueText;
    public string[] kata;
    public Sprite[] karakter;
    public Image karakterUsing;
    public int index, indexImage;
    public float dialogueSpeed;
    public GameObject DeleteButton, NextButton;
    public bool isChosen;
    public GameObject panel;
    public string[] jawabanUser;
    public bool dialogueGantiBackground;
    public GameObject gantiBackground, sakuraFlower;
    public Animator flower;

    private void Start()
    {
        if (isChosen)
        {
            indexImage = karakter.Length-1;
        }
    }

    private void Update()
    {
        Debug.Log(indexImage);
        if (!isChosen)
        {
            karakterUsing.sprite = karakter[indexImage - 1];
        }
        else
        {
            karakterUsing.sprite = karakter[indexImage];
        }

        if (dialogueGantiBackground)
        {
            if (index >= 5)
            {
                gantiBackground.gameObject.SetActive(true);
            }
            if (index >= 10)
            {
                sakuraFlower.gameObject.SetActive(true);
            }
            if (index >= 13)
            {
                flower.SetBool("left", true);
            }
        }
    }

    void muncul()
    {
        karakterUsing.gameObject.SetActive(true);
    }

    public void chosen(string jawaban)
    {
        if (jawaban == jawabanUser[0])
        {
            indexImage = 0;
            karakterUsing.gameObject.SetActive(false);
            if (index <= kata.Length - 1)
            {
                dialogueText.text = "";
                StartCoroutine(writeKataSpecial(0));
            }
            NextButton.gameObject.SetActive(false);
            muncul();
        }else if (jawaban == jawabanUser[1])
        {
            indexImage = 1;
            karakterUsing.gameObject.SetActive(false);
            if (index <= kata.Length - 1)
            {
                dialogueText.text = "";
                StartCoroutine(writeKataSpecial(1));
            }
            NextButton.gameObject.SetActive(false);
            muncul();
            NextButton.gameObject.SetActive(true);
        }
        else if (jawaban == jawabanUser[2])
        {
            indexImage = 2;
            karakterUsing.gameObject.SetActive(false);
            if (index <= kata.Length - 1)
            {
                dialogueText.text = "";
                StartCoroutine(writeKataSpecial(2));
            }
            NextButton.gameObject.SetActive(false);
            muncul();
        }
    }
    public void ButtonEnding()
    {
        transisi.gameObject.SetActive(true);
    }
    public void ButtonNext()
    {
        indexImage++;
        karakterUsing.gameObject.SetActive(false);
        if (index <= kata.Length-1)
        {
            dialogueText.text = "";
            StartCoroutine(writeKata());
        }
        NextButton.gameObject.SetActive(false);
        muncul();
        //Invoke("muncul", 0.5f);
    }
    public bool dialogueTerakhir;
    public GameObject transisi, jamButton;
    public GameObject dialogText, chosenText;
    IEnumerator writeKata()
    {
        foreach (char character in kata[index].ToCharArray())
        {
            dialogueText.text += character;
            yield return new WaitForSeconds(dialogueSpeed);
        }
        index++;
        if (index <= kata.Length - 1)
        {
            NextButton.gameObject.SetActive(true);

        }
        else
        {
            if (dialogueTerakhir)
            {
                jamButton.gameObject.SetActive(true);
            }
            else
            {
                chosenText.gameObject.SetActive(true);
                dialogText.gameObject.SetActive(false);
            }
        }
    }
    void pertanyaanmuncul()
    {

    }
    IEnumerator writeKataSpecial(int x)
    {

        index = x;
        foreach (char character in kata[index].ToCharArray())
        {
            dialogueText.text += character;
            yield return new WaitForSeconds(dialogueSpeed);
        }
        if (index <= kata.Length - 1)
        {
            panel.gameObject.SetActive(false);

        }
        else
        {
            panel.gameObject.SetActive(false);

        }
    }
}
