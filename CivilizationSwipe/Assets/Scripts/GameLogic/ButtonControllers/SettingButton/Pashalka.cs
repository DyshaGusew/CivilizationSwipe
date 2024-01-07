using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pashalka : MonoBehaviour
{
    public GameObject anime;
    public AudioSource Sound;
    public static int counter = 0;

    public void Click(GameObject anime)
    {
        counter++;
        if(counter == 10) { anime.SetActive(true); Sound.Play(); counter = 0; }
    }  
}
