using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MusicOnOff : MonoBehaviour
{
    public AudioSource audioSource;
    private bool isMusicEnabled = true;
    public Object obj;

    public void Music()
    {
        Text textComponent = obj.GetComponent<Text>();
        if (isMusicEnabled)
        {
            isMusicEnabled = false;
            audioSource.Pause();
            textComponent.text = "������ ����.";
        }
        else
        {
            isMusicEnabled = true;
            audioSource.Play();
            textComponent.text = "������ ���.";
        }
    }
}
