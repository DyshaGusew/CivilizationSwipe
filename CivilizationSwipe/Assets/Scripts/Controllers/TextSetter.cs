using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.UI;

public class TextSetter : MonoBehaviour
{
    public static GameObject mainEventText;
    public static GameObject leftEventText;
    public static GameObject rightEventText;

    public static void SetTextEvent(string texName)
    {
        if(mainEventText == null)
        {
            mainEventText.GetComponent<Text>().text = "";
        }
        mainEventText.GetComponent<Text>().text = texName;
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
}
