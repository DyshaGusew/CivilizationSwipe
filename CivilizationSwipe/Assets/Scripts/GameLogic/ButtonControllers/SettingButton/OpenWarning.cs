using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Opening a warning
public class OpenWarning : MonoBehaviour
{
    public GameObject warning;

    public void Open(GameObject warning)
    {
        warning.SetActive(true);
    }
}

