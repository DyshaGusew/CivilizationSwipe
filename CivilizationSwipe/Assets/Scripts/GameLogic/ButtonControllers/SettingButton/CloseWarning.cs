using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Closing the data reset warning
public class CloseWarning : MonoBehaviour
{
    public GameObject warning;

    public void Close(GameObject warning)
    {
        Pashalka.counter = 0;
        warning.SetActive(false);
    }
}
