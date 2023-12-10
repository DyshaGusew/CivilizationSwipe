using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SoundOnOff : MonoBehaviour
{
    public AudioSource audioSource1;
    public AudioSource audioSource2;
    public AudioSource audioSource3;
    private bool isMusicEnabled = true;
    public Object obj;
    public void Music()
    {
        Text textComponent = obj.GetComponent<Text>();
        if (isMusicEnabled)
        {
            isMusicEnabled = false;
            audioSource1.volume = 0;
            audioSource2.volume = 0;
            audioSource3.volume = 0;
            textComponent.text = "Звуки выкл.";
        }
        else
        {
            isMusicEnabled = true;
            audioSource1.volume = 1;
            audioSource2.volume = 1;
            audioSource3.volume = 1;
            textComponent.text = "Звуки вкл.";
        }
    }
}
