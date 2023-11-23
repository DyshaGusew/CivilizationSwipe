using UnityEngine;
using UnityEngine.UI;

//Набор общедоступных методов для установки значений текстам решения, имени героя и самого события
public class TextSetterView : MonoBehaviour
{
    public static GameObject mainEventText;
    public static GameObject leftEventText;
    public static GameObject rightEventText;
    public static GameObject heroNameText;

    //Установка текста героя и события
    public static void SetTextEvent(string eventText, string heroText)
    {
        mainEventText.GetComponent<Text>().text = eventText;
        heroNameText.GetComponent<Text>().text = heroText;
    }

    //Установка и активация текста левого решения
    public static void SetTextLeft()
    {
        leftEventText.GetComponent<Text>().text = MainStorage.thisCard.TextLeft;
        leftEventText.SetActive(true);
    }

    //Установка и активация текста правого решения
    public static void SetTextRight()
    {
        rightEventText.GetComponent<Text>().text = MainStorage.thisCard.TextRight;
        rightEventText.SetActive(true);
    }

    //Обнуление текстов
    public static void NullTextRightLeft()
    {
        rightEventText.SetActive(false);
        leftEventText.SetActive(false);
    }

    //Инициализация всех объектов
    public static void InicializeText()
    {
        mainEventText = GameObject.Find("EventCardText");
        leftEventText = GameObject.Find("EventLeftText");
        rightEventText = GameObject.Find("EventRightText");
        heroNameText = GameObject.Find("NameHeroCardText");

        leftEventText.SetActive(false);
        rightEventText.SetActive(false);
    }
}
