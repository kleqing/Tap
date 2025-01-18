using System;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    [SerializeField] private string volumeName;

    private void UpdateVolume()
    {
        PlayerPrefs.GetFloat(volumeName);
    }

    private void Update()
    {
        UpdateVolume();
    }
}
