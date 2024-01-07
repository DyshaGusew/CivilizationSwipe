using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

//Closing the window
public class CloseCanvas : MonoBehaviour
{
    public GameObject canvasSetting;
    public void Click()
    {
        Pashalka.counter = 0;
        canvasSetting.SetActive(false);
    }
}
