using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MiddleLineControl : MonoBehaviour
{
    public GameObject MiddleLine;
    public GameObject turnOffButtonPanel, turnOnButtonPanel;

    private void Start()
    {
        turnOnButtonPanel.gameObject.SetActive(true);
        turnOffButtonPanel.gameObject.SetActive(false);
    }

    public void turnOff()
    {
        turnOnButtonPanel.gameObject.SetActive(true);
        turnOffButtonPanel.gameObject.SetActive(false);
        MiddleLine.gameObject.SetActive(false);
    }
    public void turnOn()
    {
        turnOnButtonPanel.gameObject.SetActive(false);
        turnOffButtonPanel.gameObject.SetActive(true);
        MiddleLine.gameObject.SetActive(true);
    }
}