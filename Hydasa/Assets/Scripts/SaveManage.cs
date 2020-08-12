#define DEBUG
//#undef DEBUG

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SaveManage
{
    public enum SoundState
    {
        OFF,
        ON
    }

    public static void SaveSoundState(SoundState soundState)
    {
        string state = soundState.ToString();
        PlayerPrefs.SetString("sound", state);
        PlayerPrefs.Save();
#if DEBUG
        Debug.Log("SaveSoundState: " + state);
#endif
    }

    public static string GetSoundState()
    {
        string state;
        if (PlayerPrefs.HasKey("sound"))
        {
            state = PlayerPrefs.GetString("sound");
        }
        else
        {
            state = SoundState.ON.ToString();
            SaveSoundState(SoundState.ON);
        }
#if DEBUG
        Debug.Log("GetSoundState: " + state);
#endif
        return state;
    }
}
