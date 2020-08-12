#define DEBUG
//#undef DEBUG

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdminScript : MonoBehaviour
{
    private MusicPlay bgmPlayer;
    private ToggleButton toggleButton;

    private void Awake()
    {
        InitializeSoundAndToggle();
    }

    private void Start()
    {
        //
    }

    private void InitializeSoundAndToggle()
    {
#if DEBUG
        Debug.Log("InitializeSoundAndToggle");
#endif
        bgmPlayer = FindObjectOfType<MusicPlay>();
        toggleButton = FindObjectOfType<ToggleButton>();
        if(SaveManage.GetSoundState() == SaveManage.SoundState.ON.ToString())
        {
            toggleButton.SetToggle(true);
            if (bgmPlayer.musicClip.isPlaying) return;
            bgmPlayer.PlayMusic(true);
        }
        else
        {
            toggleButton.SetToggle(false);
            bgmPlayer.PlayMusic(false);
        }
    }
}
