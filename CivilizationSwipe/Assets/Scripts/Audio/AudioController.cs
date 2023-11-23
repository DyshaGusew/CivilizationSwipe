using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Скрипт для обработки звуков
public class AudioController : MonoBehaviour
{
    //Установка фонового звука в зависимости от переданной эры
    public void SetFoneAudio(string era)
    {
        gameObject.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>("Sound/FoneAudio/" + era);
        gameObject.GetComponent<AudioSource>().Play();
    }
}
