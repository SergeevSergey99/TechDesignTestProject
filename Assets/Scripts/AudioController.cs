using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public void PlayEffect(AudioClip clip)
    {
        AudioManager.instance.PlayEffect(clip);
    }
    public void PlayEffect()
    {
        AudioManager.instance.PlayEffect();
    }
}
