using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Closing the window
public class CloseCanvas : MonoBehaviour
{
    public GameObject canvasSetting;
    public void Click()
    {
        canvasSetting.SetActive(false);
    }
}
