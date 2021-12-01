using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip showUI;
    public AudioClip hideUI;
    public AudioClip buttonClick;
    public AudioClip equip;
    public AudioClip coinBuy;
    public AudioClip coinSell;
    public AudioClip invalidMove; 

    public List<AudioSource> audioSources;

    private static AudioManager _instance;
    public static AudioManager Instance
    {
        get { return _instance; }
    }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        _instance = this;
    }

    private AudioSource GetAvailableAudioSource() {
        for (int x = 0; x < audioSources.Count; x++) {
            if (!audioSources[x].isPlaying)
            {
                return audioSources[x];
            }
        }
        return null;
    }

    public void PlayClip(AudioClip clip)
    {
        AudioSource availableAudioSource = GetAvailableAudioSource();
        availableAudioSource.clip = clip;
        availableAudioSource.Play();
    }

    public void ShowUI()
    {
        AudioSource availableAudioSource = GetAvailableAudioSource();
        availableAudioSource.clip = showUI;
        availableAudioSource.Play();
    }

    public void HideUI()
    {
        AudioSource availableAudioSource = GetAvailableAudioSource();
        availableAudioSource.clip = hideUI;
        availableAudioSource.Play();
    }

    public void ButtonClick()
    {
        AudioSource availableAudioSource = GetAvailableAudioSource();
        availableAudioSource.clip = buttonClick;
        availableAudioSource.Play();
    }

    public void Equip()
    {
        AudioSource availableAudioSource = GetAvailableAudioSource();
        availableAudioSource.clip = equip;
        availableAudioSource.Play();
    }

    public void CoinBuy()
    {
        AudioSource availableAudioSource = GetAvailableAudioSource();
        availableAudioSource.clip = coinBuy;
        availableAudioSource.Play();
    }

    public void CoinSell()
    {
        AudioSource availableAudioSource = GetAvailableAudioSource();
        availableAudioSource.clip = coinSell;
        availableAudioSource.Play();
    }

    public void InvalidMove()
    {
        AudioSource availableAudioSource = GetAvailableAudioSource();
        availableAudioSource.clip = invalidMove;
        availableAudioSource.Play();
    }
}
