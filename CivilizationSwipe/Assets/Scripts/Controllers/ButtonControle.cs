using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonControle : MonoBehaviour
{
    public GameObject gameCard;
    [SerializeField] GameObject leftText;
    [SerializeField] GameObject rightText;
    public void ButClick()
    {
        CardConstructor.DeletePlayCard();
        CardConstructor.CreatePlayCard(gameCard);
        ButMove();
    }

    public void ButMove()
    {

        if (name == "ButtonLeft")
        {
            leftText.GetComponent<Text>().text = MainStorage.thisCard.TextLeft;
            leftText.SetActive(true);
        }

        else if (name == "ButtonRight")
        {
            rightText.GetComponent<Text>().text = MainStorage.thisCard.TextRight;
            rightText.SetActive(true);
        }
    }

    public void ButNotMove()
    {
        if (name == "ButtonLeft")
        {
            leftText.SetActive(false);
        }

        else if (name == "ButtonRight")
        {
            rightText.SetActive(false);
        }
    }
}
