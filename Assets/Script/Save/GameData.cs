using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public bool Clock;

    public GameData(detectClock x)
    {
        Clock = x.IsClock;
    }
}
