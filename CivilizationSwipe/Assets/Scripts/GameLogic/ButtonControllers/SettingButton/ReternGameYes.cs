using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnGameYes : MonoBehaviour
{
    public GameObject warning;
    public GameObject settings;
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

        warning.SetActive(false);
        settings.SetActive(false);
        EscapeScript.active = false;
    }

}
