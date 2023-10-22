using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSettings : MonoBehaviour
{
    public GameObject canvasSetting;
    
    public void Click()
    {
        canvasSetting.SetActive(true);
    }
}
