using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows;

//Класс работающий с карточкой как игровой моделью
public class CardConstructor : MonoBehaviour
{
    //Игровая карточка на сцене(берется конкретная модель с пустыми свойствами)
    public static GameObject gameCardModel;

    //Создание карточки как игрового объекта
    static public void CreatePlayCardOfBase() 
    {
        //Беру последнюю нужну карточку из массива карточек в массиве при помощи счетчика карточек, сохраняю в хранилище
        NormalCard infoCard = MainStorage.ThisCardMassive[MainStorage.counterCard-1];     //Устанавливаю карточку через номер id
        MainStorage.thisCard = infoCard;

        //Собственно создание
        GameObject newGameCard = Instantiate(gameCardModel, gameCardModel.transform.position, Quaternion.Euler(0, 0, 0));  
        newGameCard.GetComponent<SpriteRenderer>().sprite = LoadSprite(infoCard, "ProfessionIcon");

        //Увеличиваю счетчик и заношу текущую игровую карточку в хранилище
        MainStorage.counterCard++;   
        MainStorage.thisGameCard = newGameCard;
    }

    //Создание карточек смерти в зависимости от переданного на них аспекта
    static public void CreatePlayCardOfDied(string diedAspect)
    {
        NormalCard infoCard;
        switch (diedAspect)
        {
            case "money":
                infoCard = new NormalCard(JSONCardReader.GetCard("money", MainStorage.era, "DiedCard"));
                break;

            case "army":
                infoCard = new NormalCard(JSONCardReader.GetCard("army", MainStorage.era, "DiedCard"));
                break;

            case "religion":
                infoCard = new NormalCard(JSONCardReader.GetCard("religion", MainStorage.era, "DiedCard"));
                break;

            case "people":
                infoCard = new NormalCard(JSONCardReader.GetCard("people", MainStorage.era, "DiedCard"));
                break;

            default:
                infoCard = new NormalCard(JSONCardReader.GetCard(7, MainStorage.era, "DiedCard"));
                break;
        }
        //Устанавливаю эту карточку в хранилище и создаю на сцене
        MainStorage.thisCard = infoCard;
        GameObject newGameCard = Instantiate(gameCardModel, gameCardModel.transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;  //Собственно создание
        
        newGameCard.GetComponent<SpriteRenderer>().sprite = LoadSprite(infoCard, "DiedIcon");
        MainStorage.thisGameCard = newGameCard;
    }

    //Удаление карточки
    static public void DeletePlayCard()
    {
        MainStorage.thisCard = null;
    }

    //Загрузка спрайта карточки из ресурсов
    static private Sprite LoadSprite(NormalCard infoCard, string typeCard)
    {
        return Resources.Load<Sprite>(infoCard.Era + "/" + typeCard + "/" + infoCard.Image);       
    }

    //Создание массива карточек указанной эры
    public static NormalCard[] CardMassSet(string era)
    {
        //Получаю общее кол-во карточек 
        int countAllCard = MainStorage.maxCountCardOfThisEra + MainStorage.maxCountCardOfStartEra + MainStorage.maxCountCardOfEndEra;
        
        //Массив всех карточке
        NormalCard[] CardMassive = new NormalCard[countAllCard];

        //Массивы отдельных карточек
        NormalCard[] CardStart = new NormalCard[MainStorage.maxCountCardOfStartEra];  //Начальные карты эры
        NormalCard[] CardBase = new NormalCard[MainStorage.maxCountCardOfThisEra];    //Обычные карты эры
        NormalCard[] CardEnd = new NormalCard[MainStorage.maxCountCardOfEndEra];      //Конечные карты эры

        //Считываю все карточки и заношу по порядку в конкретные массивы
        for (int i = 0; i < MainStorage.maxCountCardOfStartEra; i++)
        {                               
            CardStart[i] = new NormalCard(JSONCardReader.GetCard(i+1, era, "StartCard"));
        }

        for (int i = 0; i < MainStorage.maxCountCardOfThisEra; i++)
        {                               
            CardBase[i] = new NormalCard(JSONCardReader.GetCard(i+1, era, "BaseCard"));
        }

        for (int i = 0; i < MainStorage.maxCountCardOfEndEra; i++)
        {                               
            CardEnd[i] = new NormalCard(JSONCardReader.GetCard(i + 1, era, "EndCard"));
        }

        //Перемешка массива с основными карточками(они должны быть рандомно расположены)
        for (int g = CardBase.Length - 1; g >= 1; g--)
        {
            int j = new System.Random().Next() % (g + 1);
            NormalCard tmp = CardBase[j];
            CardBase[j] = CardBase[g];
            CardBase[g] = tmp;
        }

        //Заполнение общего массива
        int f = 0;
        for(; f < MainStorage.maxCountCardOfStartEra; f++)
        {
            CardMassive[f] = CardStart[f];
        }

        for (int i = 0; i < MainStorage.maxCountCardOfThisEra; f++, i++)
        {
            CardMassive[f] = CardBase[i];
        }

        for (int j = 0; j < MainStorage.maxCountCardOfEndEra; f++, j++)
        {
            CardMassive[f] = CardEnd[j];
        }


        return CardMassive;
    }
}