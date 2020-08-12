#define DEBUG
//#undef DEBUG

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleButton : MonoBehaviour
{
    //this code is made due to unity f*ing bug with the toggle button
    private MusicPlay bgmPlayer;

    public Toggle toggleButton;

    private void Start()
    {
        bgmPlayer = FindObjectOfType<MusicPlay>();
        toggleButton = GetComponent<Toggle>();
        toggleButton.onValueChanged.AddListener(delegate {ToggleValueChangedHandler(toggleButton);});
    }

    private void ToggleValueChangedHandler(Toggle toggleBtn)
    {
        if (toggleBtn.isOn)
        {
            bgmPlayer.PlayMusic(true);
            SaveManage.SaveSoundState(SaveManage.SoundState.ON);
        }
        else
        {
            bgmPlayer.PlayMusic(false);
            SaveManage.SaveSoundState(SaveManage.SoundState.OFF);
        }
#if DEBUG
        Debug.Log("toggleBtn.isOn: " + toggleBtn.isOn);
#endif
    }

    public void SetToggle(bool toggleValue)
    {
        toggleButton.isOn = toggleValue;
#if DEBUG
        Debug.Log("SetToggle to: " + toggleValue);
#endif
    }
}
