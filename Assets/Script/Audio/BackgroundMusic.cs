using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundMusic : MonoBehaviour
{
    public static BackgroundMusic Instance { get; private set; }
    private AudioSource source;
    
    [Header("Sound Icon")]
    [SerializeField] private List<Image> soundIcon = new List<Image>();
    [SerializeField] private Sprite muteIcon;
    [SerializeField] private Sprite unmuteIcon;

    private void Awake()
    {
        
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (Instance != this && Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        
        source = GetComponent<AudioSource>();
        
        if (!source.isPlaying)
        {
            source.Play();
        }
    }
    
    public void Mute(float volume)
    {
        float maxVolume = 0.2f;
        float currentVolume = PlayerPrefs.GetFloat("Volume");
        currentVolume += volume;
        
        if (currentVolume > maxVolume)
        {
            currentVolume = 0;
        }
        else if (currentVolume < 0)
        {
            currentVolume = maxVolume;
        }
        
        source.volume = currentVolume;
        
        //* Save volume
        PlayerPrefs.SetFloat("Volume", currentVolume);
        foreach (var icon in soundIcon)
        {
            UpdateIcon(icon, currentVolume);
        }
    }
    
    private void UpdateIcon(Image icon, float volume)
    {
        if (icon ==  null || muteIcon == null || unmuteIcon == null)
        {
            return;
        }
        icon.sprite = source.volume > 0 ? unmuteIcon : muteIcon;
    }
    
    public void RegisterSoundIcon(Image icon)
    {
        if (!soundIcon.Contains(icon))
        {
            soundIcon.Add(icon);
            UpdateIcon(icon, source.volume);
        }
    }
    
    public void UnregisterSoundIcon(Image icon)
    {
        if (soundIcon.Contains(icon))
        {
            soundIcon.Remove(icon);
        }
    }
    
}
