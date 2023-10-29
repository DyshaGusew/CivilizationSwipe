using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameController : MonoBehaviour
{
    static public bool gameOver = false;

    static public void ControleAfterBut()
    {
        if(gameOver == false)
        {
            if (MainStorage.Money > 1 && MainStorage.Army > 1 && MainStorage.Religion > 1 && MainStorage.People > 1)
            {
                if (MainStorage.counterCard != MainStorage.maxCountCardOfThisEra + MainStorage.maxCountCardOfStartEra + 1)
                {
                    CardConstructor.CreatePlayCardOfBase();
                    TextSetterView.SetTextEvent(MainStorage.thisCard.TextEvent, MainStorage.thisCard.TextHero);
                }
                else
                {
                    //������������ �������� ���
                    for (int i = 0; i < MainStorage.eras.Length; i++)
                    {
                        if (MainStorage.eras[i] == MainStorage.era)
                        {
                            MainStorage.era = MainStorage.eras[i + 1];
                            break;
                        }
                    }

                    MainStorage.maxCountCardOfThisEra = System.IO.Directory.GetFiles(Application.streamingAssetsPath + "\\CardListJSON\\" + MainStorage.era + "\\BaseCard\\", "*.json").Length;
                    MainStorage.maxCountCardOfStartEra = System.IO.Directory.GetFiles(Application.streamingAssetsPath + "\\CardListJSON\\" + MainStorage.era + "\\StartCard\\", "*.json").Length;
                    MainStorage.counterCard = 1;

                    MainStorage.Save();

                    MainStorage.ThisCardMassive = CardConstructor.CardMassSet(MainStorage.era);
                    CardConstructor.CreatePlayCardOfBase();
                    TextSetterView.SetTextEvent(MainStorage.thisCard.TextEvent, MainStorage.thisCard.TextHero);
                }
            }

            else
            {
                gameOver = true;
                if (MainStorage.Money <= 0)
                {
                    CardConstructor.CreatePlayCardOfDied("money");
                }
                else if (MainStorage.Army <= 0)
                {
                    CardConstructor.CreatePlayCardOfDied("army");
                }
                else if (MainStorage.Religion <= 0)
                {
                    CardConstructor.CreatePlayCardOfDied("religion");
                }
                else if (MainStorage.People <= 0)
                {
                    CardConstructor.CreatePlayCardOfDied("people");
                }
                TextSetterView.SetTextEvent(MainStorage.thisCard.TextEvent, MainStorage.thisCard.TextHero);
            }
        }
        else
        {//sdf
            GameObject.Find("Main Camera").GetComponent<NewGame>().AtiveExitMenu();
            GameOver();
        }
        
    }


    static void GameOver()
    {
        MainStorage.Money = 50;
        MainStorage.Army = 50;
        MainStorage.Religion = 50;
        MainStorage.People = 50;
        MainStorage.counterCard = 1;
        MainStorage.era = "Tribe";
        gameOver = false;

        MainStorage.Save();

        MainStorage.ThisCardMassive = CardConstructor.CardMassSet(MainStorage.era);
        CardConstructor.CreatePlayCardOfBase();
        TextSetterView.SetTextEvent(MainStorage.thisCard.TextEvent, MainStorage.thisCard.TextHero);
        AspectGreenRed.AspectLightSol(0,0,0,0);
    }
}
