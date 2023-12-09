using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//sound when flipping through the card
public class AudioSwipe : MonoBehaviour
{
    public AudioSource Sound;

    public void Play_Sound()
    {
        Sound.Play();
    }
}
