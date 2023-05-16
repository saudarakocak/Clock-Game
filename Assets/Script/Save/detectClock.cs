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
        /// <permission cref="Ijinkan">description</permission>
        if (isLoading)
        {
            bool x = SaveSystem.LoadData().Clock;
            if (x != null)
            {
                IsClock = x;
            }
            else {
                IsClock = false;
            }
        }
    }

    public void IsclockSave()
    {
        IsClock = true;
        SaveSystem.SaveData(this);
    }


}
