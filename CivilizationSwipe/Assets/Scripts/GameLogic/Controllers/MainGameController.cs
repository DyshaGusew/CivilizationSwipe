using Unity.VisualScripting;
using UnityEngine;

//Controller of the main events of the game
public class MainGameController : MonoBehaviour
{
    //The general access variable of the end of the game
    static public bool gameOver = false;

    //The method for triggering after pressing
    static public void ControleAfterBut(string solution)
    {
        //When the end of the games has already come, we enterà
        if (gameOver == false)
        {
            //If all the parameters are normal after clicking, then look at
            if (MainStorage.Money > 0 && MainStorage.Army > 0 && MainStorage.Religion > 0 && MainStorage.People > 0)
            {
                //We create a new card and set the text for it if it does not go beyond this era
                if (MainStorage.counterCard != MainStorage.maxCountCardOfThisEra + MainStorage.maxCountCardOfStartEra + MainStorage.maxCountCardOfEndEra + 1)
                {
                    if(MainStorage.thisCard.TextEvent == null)
                    {
                        Debug.Log(MainStorage.thisCard.TextEvent);
                        CardConstructor.CreatePlayCardOfBase();
                    }
                    else
                    {
                        if ((MainStorage.thisCard.NextCardL == 0 && MainStorage.thisCard.NextCardR == 0))
                        {
                            CardConstructor.CreatePlayCardOfBase();
                            Debug.Log(MainStorage.thisCard.TextEvent);
                        }
                        else
                        {
                            if (solution == "left")
                            {
                                if (MainStorage.thisCard.NextCardL != 0)
                                    CardConstructor.CreatePlayCardOfNext(MainStorage.thisCard.NextCardL);
                                else
                                    CardConstructor.CreatePlayCardOfBase();
                            }
                            else
                            {
                                if(MainStorage.thisCard.NextCardR != 0)                                {
                                    CardConstructor.CreatePlayCardOfNext(MainStorage.thisCard.NextCardR);                                }
                                else                                {
                                    CardConstructor.CreatePlayCardOfBase();                                }
                            }
                        }          
                    }    
                    TextSetterView.SetTextEvent(MainStorage.thisCard.TextEvent, MainStorage.thisCard.TextHero);
                }
                //If there are no more cards in the current era, then enter
                else
                {
                    //If this is the last era, then I'm bringing out the final window
                    if (MainStorage.era == MainStorage.eras[5])
                    {
                        CardConstructor.CreatePlayCardOfDied("people");
                        GameObject.Find("Main Camera").GetComponent<OpenWindowWinOrFail>().AtiveWinMenu();
                        MainStorage.LoadNormalValue();
                        return;
                    }

                    //Switching the era and setting the initial values (initial for this era)
                    else
                    {
                        string thisEra = MainStorage.era;
                        MainStorage.LoadNormalValue();
                        MainStorage.learning = 1;
                        MainStorage.era = thisEra;

                        //Setting the next era
                        for (int i = 0; i < MainStorage.eras.Length; i++)
                        {
                            if (MainStorage.eras[i] == MainStorage.era)
                            {
                                MainStorage.era = MainStorage.eras[i + 1];
                                break;
                            }
                        }

                        //I install everything in the mainStorage and save it
                        MainStorage.maxCountCardOfThisEra = System.IO.Directory.GetFiles(Application.streamingAssetsPath + "\\CardListJSON\\" + MainStorage.era + "\\BaseCard\\", "*.json").Length;
                        MainStorage.maxCountCardOfStartEra = System.IO.Directory.GetFiles(Application.streamingAssetsPath + "\\CardListJSON\\" + MainStorage.era + "\\StartCard\\", "*.json").Length;
                        MainStorage.maxCountCardOfEndEra = System.IO.Directory.GetFiles(Application.streamingAssetsPath + "\\CardListJSON\\" + MainStorage.era + "\\EndCard\\", "*.json").Length;
                        MainStorage.counterCard = 1;

                        MainStorage.Save();

                        //I create arrays, take out the card and set the environment
                        MainStorage.ThisCardMassive = CardConstructor.CardMassSet(MainStorage.era);
                        CardConstructor.CreatePlayCardOfBase();
                        TextSetterView.SetTextEvent(MainStorage.thisCard.TextEvent, MainStorage.thisCard.TextHero);
                        FoneAspectSetter.FoneSet();
                        FoneAspectSetter.AspecSet();
                        GameObject.Find("FoneAudio").GetComponent<AudioController>().SetFoneAudio(MainStorage.era);
                    }
                }
            }

            //If one of the parameters has dropped to 0, then I display the death card,
            //set game over true and the next time I scroll, the loss window will be displayed
            else
            {
                //I'm determining which death card to display
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

        //If the gameOver parameter = true, then the displayed card is already
        //a death card and after merging it, I display the loss window
        else
        {
            //I create a random card so that when hovering over its buttons,
            //but before creating the menu, there are no errors
            CardConstructor.CreatePlayCardOfDied("people");
            GameObject.Find("Main Camera").GetComponent<OpenWindowWinOrFail>().AtiveExitMenu();
            MainStorage.LoadNormalValue();
            return;
        }
        
    }

    //Creating a new game, all from scratch
    public static void NewGameCreate()
    {
        gameOver = false;
        MainStorage.LoadNormalValue();
        MainStorage.learning = 1;
        MainStorage.Save();
        MainStorage.ThisCardMassive = CardConstructor.CardMassSet(MainStorage.era);
        CardConstructor.CreatePlayCardOfBase();
        TextSetterView.SetTextEvent(MainStorage.thisCard.TextEvent, MainStorage.thisCard.TextHero);
        AspectGreenRed.AspectLightSol(0,0,0,0);
    }
}
