using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Opening a warning
public class OpenWarning : MonoBehaviour
{
    public GameObject warning;

    public void Open(GameObject warning)
    {
        Pashalka.counter = 0;
        warning.SetActive(true);
    }
}

