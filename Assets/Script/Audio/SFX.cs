using UnityEngine;

public class SFX : MonoBehaviour
{
    public static SFX Instance { get; private set; }
    
    private AudioSource source;
    
    private void Awake()
    {
        source = GetComponent<AudioSource>();
        
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
    }
    
    public void PlaySound(AudioClip clip)
    {
        source.PlayOneShot(clip);
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
    }
}
