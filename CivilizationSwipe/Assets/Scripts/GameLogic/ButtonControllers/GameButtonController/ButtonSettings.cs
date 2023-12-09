using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The button to open the settings menu
public class ButtonSettings : MonoBehaviour
{
    public GameObject canvasSetting;
    public GameObject warning;

    //Here, when clicked, the settings menu opens
    public void Click()
    {
        EscapeScript.active = true;
        canvasSetting.SetActive(true);
        warning.SetActive(false);
    }
}
