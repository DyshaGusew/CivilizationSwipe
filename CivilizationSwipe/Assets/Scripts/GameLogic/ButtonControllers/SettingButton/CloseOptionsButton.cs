using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Closing the settings window
public class CloseOptionsButton : MonoBehaviour
{
    public GameObject canvasSetting;
    public GameObject anime;
    public void Click()
    {
        Pashalka.counter = 0;
        anime.SetActive(false);
        canvasSetting.SetActive(false);
        EscapeScript.active = false;
    }
}
