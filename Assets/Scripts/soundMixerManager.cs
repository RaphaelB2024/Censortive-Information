using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class soundMixerManager : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;

    public void setMasterVol(float level)
    {
        audioMixer.SetFloat("masterVolume", level);
    }

    public void setFXVol(float level)
    {
        audioMixer.SetFloat("sfxVolume", level);
    }

    public void setMusicVol(float level)
    {
        audioMixer.SetFloat("musicVolume", level);
    }
}
