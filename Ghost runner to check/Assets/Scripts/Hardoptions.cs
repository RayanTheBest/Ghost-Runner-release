using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class Hardoptions : MonoBehaviour
{

    public AudioMixer audioMixer;

    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("VOLUME", volume);
    }

    public void setQualty(int qualtyIndex)
    {
        QualitySettings.SetQualityLevel(qualtyIndex);
    }

    public void SetFullscreen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

   
}
