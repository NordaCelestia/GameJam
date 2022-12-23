using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ayarButon : MonoBehaviour
{
    

    public Slider slider;


    private void Start()
    {
        LoadAudio();
    }


    public void SetAudio(float value)
    {

        AudioListener.volume = value;
        
        SaveAudio();

    }

    private void SaveAudio()
    {
        PlayerPrefs.SetFloat("audioVolume", AudioListener.volume);

    }

    private void LoadAudio()
    {

        if (PlayerPrefs.HasKey("audioVolume"))
        {


            AudioListener.volume = PlayerPrefs.GetFloat("audioVolume");
            slider.value = AudioListener.volume = PlayerPrefs.GetFloat("audioVolume");
        }
        else
        {

            PlayerPrefs.SetFloat("audioVolume", 1f);

        }
    }
}
