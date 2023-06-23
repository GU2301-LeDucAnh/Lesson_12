using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserProfile : MonoBehaviour
{
    public int CurrentSkin
    {
        get
        {
            return PlayerPrefs.GetInt(StringHelper.CURRENT_SKIN);
        }
        set
        {
            PlayerPrefs.SetInt(StringHelper.CURRENT_SKIN, value);
            PlayerPrefs.Save();
        }
    }

    public bool OnVibration
    {
        get
        {
            return PlayerPrefs.GetInt(StringHelper.ONOFF_VIBRATION) == 1 ? true : false;
        }
        set
        {
            PlayerPrefs.SetInt(StringHelper.ONOFF_VIBRATION, value ? 1 : 0);
        }
    }

    public float SoundVolume
    {
        get
        {
            return PlayerPrefs.GetFloat(StringHelper.SOUND_VOLUME);
        }
        set
        {
            PlayerPrefs.SetFloat(StringHelper.SOUND_VOLUME, value);
        }
    }

    public float MusicVolume
    {
        get
        {
            return PlayerPrefs.GetFloat(StringHelper.MUSIC_VOLUME);
        }
        set
        {
            PlayerPrefs.SetFloat(StringHelper.MUSIC_VOLUME, value);
        }
    }
}
