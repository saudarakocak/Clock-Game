using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class detectClock : MonoBehaviour
{
    public bool IsClock = false;
    public bool isLoading = false;

    private void Start()
    {
        if (isLoading)
        {
            bool x = SaveSystem.LoadData().Clock;
            if (x != null)
            {
                IsClock = x;
            }
        }
    }

    public void IsclockSave()
    {
        IsClock = true;
        SaveSystem.SaveData(this);
    }


}
