using UnityEngine;

//Контроллер оснывных событий игры
public class MainGameController : MonoBehaviour
{
    //Общедуступная переменная конца игры
    static public bool gameOver = false;

    //Метод для срабатывания после нажатия
    static public void ControleAfterBut()
    {
        //Когда конец игр ыне наступил входим
        if(gameOver == false)
        {
            //Если после нажатия все параметры нормальные, то смотрим
            if (MainStorage.Money >= 0 && MainStorage.Army >= 0 && MainStorage.Religion >= 0 && MainStorage.People >= 0)
            {
                //Создаем новую карточку и устанавливаем ей текста если это не выходим за пределы данной эры
                if (MainStorage.counterCard != MainStorage.maxCountCardOfThisEra + MainStorage.maxCountCardOfStartEra + MainStorage.maxCountCardOfEndEra + 1)
                {
                    CardConstructor.CreatePlayCardOfBase();
                    TextSetterView.SetTextEvent(MainStorage.thisCard.TextEvent, MainStorage.thisCard.TextHero);
                }
                //Если в текущей эре больше нет карт, то входим
                else
                {
                    //Если это последняя эра, то вывожу финальное окно
                    if (MainStorage.era == MainStorage.eras[5])
                    {
                        GameObject.Find("Main Camera").GetComponent<OpenWindowWinOrFail>().AtiveWinMenu();
                        NewGameCreate();  
                    }
                    //Переключение эры и установка начальных значений(начальных для данной эры)
                    else
                    {
                        string thisEra = MainStorage.era;
                        MainStorage.LoadNormalValue();
                        MainStorage.learning = 1;
                        MainStorage.era = thisEra;
                        //Устанавливаю следущую эру
                        for (int i = 0; i < MainStorage.eras.Length; i++)
                        {
                            if (MainStorage.eras[i] == MainStorage.era)
                            {
                                MainStorage.era = MainStorage.eras[i + 1];
                                break;
                            }
                        }
                        //Устанавливаю все в mainStorage и сохраняю
                        MainStorage.maxCountCardOfThisEra = System.IO.Directory.GetFiles(Application.streamingAssetsPath + "\\CardListJSON\\" + MainStorage.era + "\\BaseCard\\", "*.json").Length;
                        MainStorage.maxCountCardOfStartEra = System.IO.Directory.GetFiles(Application.streamingAssetsPath + "\\CardListJSON\\" + MainStorage.era + "\\StartCard\\", "*.json").Length;
                        MainStorage.maxCountCardOfEndEra = System.IO.Directory.GetFiles(Application.streamingAssetsPath + "\\CardListJSON\\" + MainStorage.era + "\\EndCard\\", "*.json").Length;
                        MainStorage.counterCard = 1;

                        MainStorage.Save();

                        //Создаю массивы, выожу карточку и устанавливаю окружение
                        MainStorage.ThisCardMassive = CardConstructor.CardMassSet(MainStorage.era);
                        CardConstructor.CreatePlayCardOfBase();
                        TextSetterView.SetTextEvent(MainStorage.thisCard.TextEvent, MainStorage.thisCard.TextHero);
                        FoneAspectSetter.FoneSet();
                        FoneAspectSetter.AspecSet();
                    }
                }
            }

            //Если один из параметров упал до 0, то вывожу карточку смерти, устанавливаю game over true и при следующем листании выведится окно проигрыша
            else
            {
                //Определяю какую карточку смерти выводить
                gameOver = true;
                if (MainStorage.Money < 0)
                {
                    CardConstructor.CreatePlayCardOfDied("money");
                }
                else if (MainStorage.Army < 0)
                {
                    CardConstructor.CreatePlayCardOfDied("army");
                }
                else if (MainStorage.Religion < 0)
                {
                    CardConstructor.CreatePlayCardOfDied("religion");
                }
                else if (MainStorage.People < 0)
                {
                    CardConstructor.CreatePlayCardOfDied("people");
                }
                TextSetterView.SetTextEvent(MainStorage.thisCard.TextEvent, MainStorage.thisCard.TextHero); 
            }
        }
        //Если параметр gameOver = true, то выведенная карточка уже карточка смерти и после ее слистывания вывожу окно проигрыша
        else
        {
            GameObject.Find("Main Camera").GetComponent<OpenWindowWinOrFail>().AtiveExitMenu();
            NewGameCreate();
        }
        
    }

    //Создание новой игры, все с нуля
    static void NewGameCreate()
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
