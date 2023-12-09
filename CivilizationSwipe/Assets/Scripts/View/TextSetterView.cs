using UnityEngine;
using UnityEngine.UI;

//A set of publicly available methods for setting values for the texts of the decision,
//the name of the hero and the event itself
public class TextSetterView : MonoBehaviour
{
    public static GameObject mainEventText;
    public static GameObject leftEventText;
    public static GameObject rightEventText;
    public static GameObject heroNameText;

    //Setting the text of the hero and the event
    public static void SetTextEvent(string eventText, string heroText)
    {
        mainEventText.GetComponent<Text>().text = eventText;
        heroNameText.GetComponent<Text>().text = heroText;
    }

    //Installing and activating the text of the left solution
    public static void SetTextLeft()
    {
        if(!MainStorage.thisCard.TextLeft.Equals(""))
        {
            leftEventText.GetComponent<Text>().text = MainStorage.thisCard.TextLeft;
            leftEventText.SetActive(true);
        }
    }

    //Installing and activating the text of the right solution
    public static void SetTextRight()
    {
        if (!MainStorage.thisCard.TextRight.Equals(""))
        {
            rightEventText.GetComponent<Text>().text = MainStorage.thisCard.TextRight;
            rightEventText.SetActive(true);
        }
    }

    //Zeroing out texts
    public static void NullTextRightLeft()
    {
        rightEventText.SetActive(false);
        leftEventText.SetActive(false);
    }

    //Initializing all objects
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
