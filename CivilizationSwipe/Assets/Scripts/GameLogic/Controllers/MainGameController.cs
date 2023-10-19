using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameController : MonoBehaviour
{
    static public void ControleAfterBut()
    {
        if (MainStorage.money > 0 && MainStorage.army > 0 && MainStorage.religion > 0 && MainStorage.people > 0)
        {
            if (MainStorage.counterCard != MainStorage.maxCountCardOfThisEra+1)
            {
                CardConstructor.CreatePlayCard();
                TextSetterView.SetTextEvent(MainStorage.thisCard.TextEvent);
            }
            else
            {
                //Устанавливаю следущую эру
                for(int i = 0; i < MainStorage.eras.Length; i++)
                {
                    if (MainStorage.eras[i] == MainStorage.era)
                    {
                        MainStorage.era = MainStorage.eras[i+1];
                        break;
                    }
                }

                MainStorage.maxCountCardOfThisEra = System.IO.Directory.GetFiles(Application.streamingAssetsPath + "\\CardListJSON\\" + MainStorage.era, "*.json").Length;
                MainStorage.counterCard = 1;

                MainStorage.Save();

                MainStorage.ThisCardMassive = CardConstructor.CardMassSet(MainStorage.era);
                CardConstructor.CreatePlayCard();
                TextSetterView.SetTextEvent(MainStorage.thisCard.TextEvent);
            }
        }
        else
        {
            GameOver();
        }
    }

    static void GameOver()
    {
        Debug.Log("Вы проиграли");
        MainStorage.money = 50;
        MainStorage.army = 50;
        MainStorage.religion = 50;
        MainStorage.people = 50;
        MainStorage.counterCard = 1;
        MainStorage.era = "Tribe";

        MainStorage.Save();

        MainStorage.ThisCardMassive = CardConstructor.CardMassSet(MainStorage.era);
        CardConstructor.CreatePlayCard();
        TextSetterView.SetTextEvent(MainStorage.thisCard.TextEvent);
    }
}
