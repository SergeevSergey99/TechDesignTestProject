using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance = null;
    public AudioSource musicSource;
    public AudioSource effectsSource;

    private void Awake()
    {
        if (instance == null)
        {       
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
            Destroy(gameObject); // Prevents duplicates
    }
    
    public void PlayMusic(AudioClip clip)
    {
        musicSource.clip = clip;
        musicSource.Play();
    }
    
    public void PlayEffect(AudioClip clip)
    {
        effectsSource.clip = clip;
        effectsSource.Play();
    }
    public void PlayEffect()
    {
        effectsSource.Play();
    }
    public void StopMusic()
    {
        musicSource.Stop();
    }
    public void StopEffect()
    {
        effectsSource.Stop();
    }

    private void OnDestroy()
    {
        if (instance == this)
        {
            instance = null;
        }
    }
}
