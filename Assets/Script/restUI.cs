using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restUI : MonoBehaviour
{
    public Animator PanelW, PanelS, PanelM;
    public float timeHide;
    float tempTime;
    public bool isHide;
    public bool isOpen;

    public GameObject Dot;

    private void Start()
    {
        Dot.gameObject.SetActive(false);
        tempTime = timeHide;
    }

    private void Update()
    {
        if (!isOpen)
        {
            if (!isHide)
            {
                timeHide -= Time.deltaTime;
                if (timeHide <= 0)
                {
                    PanelM.SetBool("hide", true);
                    PanelW.SetBool("hide", true);
                    PanelS.SetBool("hide", true);
                    isHide = true;
                    timeHide = tempTime;
                    Dot.gameObject.SetActive(true);
                }
            }
        }

        if (isHide)
        {
            Dot.gameObject.SetActive(true);
        }

    }

    public void Unhide()
    {
        isHide = false;
    }

    public void OpenIt()
    {
        isOpen = true;
    }
    public void ClosedIt()
    {
        timeHide = tempTime;
        isOpen = false;
    }

    public void restartTime()
    {
        timeHide = tempTime;
    }
}
