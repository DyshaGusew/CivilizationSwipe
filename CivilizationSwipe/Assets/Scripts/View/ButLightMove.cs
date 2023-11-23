using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Настройка цвета текста кнопок при наведении
public class ButLightMove : MonoBehaviour
{
    public GameObject text;

    //Навел - цвет темнее
    public void MoveOn()
    {
        ColorUtility.TryParseHtmlString("#919191", out Color col1);
        text.GetComponent<Text>().color = col1;
    }

    //Убрал - цвет белый
    public void MoveOff()
    {
        ColorUtility.TryParseHtmlString("#FFFFFF", out Color col1);
        text.GetComponent<Text>().color = col1;
    }

    //При активации цвет белый
    private void OnEnable()
    {
        MoveOff();    
    }
}
