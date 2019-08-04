using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public AudioClip pourBeer;
    public AudioClip gainMoney;
    public AudioClip loseMoney;

    public AudioSource AudioSource;

    public void PlaySound(AudioClip audioClip)
    {
        AudioSource.PlayOneShot(audioClip);
    }
}
