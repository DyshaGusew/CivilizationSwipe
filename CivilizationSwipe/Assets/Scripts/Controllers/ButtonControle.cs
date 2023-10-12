using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonControle : MonoBehaviour
{
    public GameObject gameCard;

    public void ButClick()
    {
        if (name == "ButtonLeft")
        {
            AspectSetter.AspectLeftSolution();
        }

        else if(name == "ButtonRight")
        {
            AspectSetter.AspectRightSolution();
        }

        CardConstructor.DeletePlayCard();
        CardConstructor.CreatePlayCard(gameCard);

        TextSetter.SetTextEvent(MainStorage.thisCard.TextEvent);

        ButMove();
    }

    public void ButMove()
    {
        if (name == "ButtonLeft")
        {
            TextSetter.SetTextLeft();
        }

        else if (name == "ButtonRight")
        {
            TextSetter.SetTextRight();
        }
    }

    public void ButNotMove()
    {
        TextSetter.NullTextRightLeft();
    }
}
