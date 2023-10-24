using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.UI;

public class TextSetterView : MonoBehaviour
{
    public static GameObject mainEventText;
    public static GameObject leftEventText;
    public static GameObject rightEventText;
    public static GameObject heroNameText;

    public static void SetTextEvent(string eventText, string heroText)
    {
        mainEventText.GetComponent<Text>().text = eventText;
        heroNameText.GetComponent<Text>().text = heroText;
    }

    public static void SetTextLeft()
    {
        leftEventText.GetComponent<Text>().text = MainStorage.thisCard.TextLeft;
        leftEventText.SetActive(true);
    }

    public static void SetTextRight()
    {
        rightEventText.GetComponent<Text>().text = MainStorage.thisCard.TextRight;
        rightEventText.SetActive(true);
    }


    public static void NullTextRightLeft()
    {
        rightEventText.SetActive(false);
        leftEventText.SetActive(false);
    }

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
