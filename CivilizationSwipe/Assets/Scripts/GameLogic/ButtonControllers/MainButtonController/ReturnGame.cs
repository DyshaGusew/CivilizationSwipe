using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnGame : MonoBehaviour
{
    public void Return()
    {
        PlayerPrefs.DeleteAll();
        MainStorage.LoadNormalValue();
        MainGameController.gameOver = false;


        CardConstructor.DeletePlayCard();
        MainStorage.ThisCardMassive = CardConstructor.CardMassSet(MainStorage.era);
        CardConstructor.CreatePlayCardOfBase();
        TextSetterView.SetTextEvent(MainStorage.thisCard.TextEvent, MainStorage.thisCard.TextHero);
        AspectGreenRed.AspectLightSol(0, 0, 0, 0);
    }

}
