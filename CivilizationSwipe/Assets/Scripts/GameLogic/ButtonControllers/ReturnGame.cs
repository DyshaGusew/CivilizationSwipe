using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnGame : MonoBehaviour
{
    public GameObject gameCard;
    public void Return()
    {
        MainStorage.money = 50;
        MainStorage.army = 50;
        MainStorage.religion = 50;
        MainStorage.people = 50;
        MainStorage.counterCard = 1;
        MainStorage.era = "Tribe";

        MainStorage.Save();

        CardConstructor.DeletePlayCard();
        MainStorage.ThisCardMassive = CardConstructor.CardMassSet(MainStorage.era);
        CardConstructor.CreatePlayCard();
        TextSetterView.SetTextEvent(MainStorage.thisCard.TextEvent);
    }

}
