using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainControl : MonoBehaviour
{
    public float second, minute, hour;
    public TMP_Text secondText, minuteText, hourText, PMText;
    string PM;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //second
        second = System.DateTime.Now.Second;
        secondText.text = second.ToString();

        //minute
        minute = System.DateTime.Now.Minute;
        minuteText.text = minute.ToString();

        //hour
        int x = System.DateTime.Now.Hour;
        if (x >= 13)
        {
            PM = "PM";
            x -= 12;
        }else
        {
            PM = "AM";
        }
        hour = x;
        hourText.text = hour.ToString();
        //PM-AM
        PMText.text = PM;
    }
}
