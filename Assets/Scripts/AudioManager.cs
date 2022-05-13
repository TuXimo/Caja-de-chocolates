using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    private AudioSource _audioSource;
    private Button _button;
    public AudioClip AudioClip;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            PlaySound();
        }
    }

    public void PlaySound()
    {
        _audioSource.PlayOneShot(AudioClip);
    }
}
