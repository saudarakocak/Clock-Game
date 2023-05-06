using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    public Animator wallpaperPanel, soundPanel, middlePanel, supportPanel;

    public void wallpaperPanelHide()
    {
        wallpaperPanel.SetBool("move", true);
    }

    public void soundPanelHid()
    {
        soundPanel.SetBool("move", true);
    }

    public void middlePanelHide()
    {
        middlePanel.SetBool("move", true);
    }

    public void supportPanelHide()
    {
        supportPanel.SetBool("unhide", true);
    }
}
