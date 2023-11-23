using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Контроль отображения фона игры и стиля аспектов
public class FoneAspectSetter : MonoBehaviour
{
    //Установка фона
    static public void FoneSet()
    {
        GameObject.Find("Background").GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Fones/" + MainStorage.era);
    }

    //Установка аспектов в зависимости от переданной эры
    static public void AspecSet()
    {
        //Устанавливаю сами аспекты (их вид)
        GameObject.Find("Aspects").GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Aspects/" + MainStorage.era);
       
        //Установка цвета верхней линии
        switch (MainStorage.era)
        {
            //Для каждой эры свой цвет
            case "Tribe":
                Color color = new Color(0.3803922f, 0.2156863f, 0.09019608f);
                GameObject.Find("UpLine").GetComponent<SpriteRenderer>().color = color;
                break;

            case "MiddleAges":
                Color color1 = new Color(0.4f, 0.4f, 0.4f);
                GameObject.Find("UpLine").GetComponent<SpriteRenderer>().color = color1;
                break;

            case "NewTime":
                Color color2 = new Color(0.8f, 0.8f, 0.8f);
                GameObject.Find("UpLine").GetComponent<SpriteRenderer>().color = color2;
                break;

            case "ModernTime":
                Color color3 = new Color(0.1f, 0.1f, 0.1f);
                GameObject.Find("UpLine").GetComponent<SpriteRenderer>().color = color3;
                break;

            case "CyberTime":
                Color color4 = new Color(0.6f, 0.6f, 0.6f);
                GameObject.Find("UpLine").GetComponent<SpriteRenderer>().color = color4;
                break;
            default:
                
                break;
        }
    }
}
