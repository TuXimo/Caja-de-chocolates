using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundSettings : MonoBehaviour
{
    public AudioMixer soundMixer, musicMixer;
    
    public void SetVolume(float volume)
    {
        soundMixer.SetFloat("volume", volume);
        musicMixer.SetFloat("volume", volume);
    }
}
    