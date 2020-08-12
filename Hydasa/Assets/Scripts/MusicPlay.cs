#define DEBUG
//#undef DEBUG

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlay : MonoBehaviour
{
    public AudioSource musicClip;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if(FindObjectsOfType<MusicPlay>().Length > 1)
        {
            Destroy(gameObject);
        }
    }

    public void ChangeMusic(AudioClip audioClip)
    {
        if (audioClip == musicClip || audioClip == null) return;
        musicClip.clip = audioClip;
    }

    public void PlayMusic(bool isPlay)
    {
        if(isPlay) musicClip.Play();
        else musicClip.Stop();
#if DEBUG
        Debug.Log("PlayMusic: " + isPlay);
#endif
    }
}
