using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OnClickEvents : MonoBehaviour
{
    public TextMeshProUGUI soundsText;
    void Start()
    {
        if (LevelManager.mute)
        {
            soundsText.text = "/";
        }
        else
        {
            soundsText.text = "";
        }
    }

    public void ToggleMute()
    {
        if (LevelManager.mute)
        {
            LevelManager.mute = false;
            soundsText.text = "";
        }
        else
        {
            LevelManager.mute = true;
            soundsText.text = "/";
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    
    
}
