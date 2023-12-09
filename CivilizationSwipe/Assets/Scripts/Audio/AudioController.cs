using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//A script for processing sounds
public class AudioController : MonoBehaviour
{
    //Setting the background sound depending on the transmitted era
    public void SetFoneAudio(string era)
    {
        gameObject.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>("Sound/FoneAudio/" + era);
        gameObject.GetComponent<AudioSource>().Play();
    }
}
