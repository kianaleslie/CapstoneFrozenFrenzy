using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    bool isMuted = false;

    public GameObject mutedImage;

    private void Start()
    {
        mutedImage.SetActive(false);
    }

    //kiana - this method is used to mute the audio and is used on the mute button on the main menu
    public void MuteAudio()
    {
        isMuted = !isMuted;

        if(isMuted)
        {
            audioSource.volume = 0f;
            mutedImage.SetActive(true);
        }
        else
        {
            audioSource.volume = 0.1f;
            mutedImage?.SetActive(false);
        }
    }
}