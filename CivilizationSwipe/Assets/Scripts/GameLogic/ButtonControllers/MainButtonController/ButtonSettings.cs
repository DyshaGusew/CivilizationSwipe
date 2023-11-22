using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Кнопка открытия меню настроек
public class ButtonSettings : MonoBehaviour
{
    public GameObject canvasSetting;
    public GameObject warning;

    //Тут все понятно
    public void Click()
    {
        canvasSetting.SetActive(true);
        warning.SetActive(false);
    }
}
