using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseWarning : MonoBehaviour
{
    public GameObject warning;

    public void Close(GameObject warning)
    {
        warning.SetActive(false);
    }
}
