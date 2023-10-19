using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnGame : MonoBehaviour
{
    public GameObject gameCard;
    public void Return()
    {
        PlayerPrefs.DeleteAll();
        MainStorage.LoadNormalValue();

        CardConstructor.DeletePlayCard();
        MainStorage.ThisCardMassive = CardConstructor.CardMassSet(MainStorage.era);
        CardConstructor.CreatePlayCard();
        TextSetterView.SetTextEvent(MainStorage.thisCard.TextEvent);
    }

}
