using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows;

public class CardConstructor : MonoBehaviour
{
    public static GameObject gameCard;

    //Создание карточки как игрового объекта
    static public void CreatePlayCardOfBase() 
    {
        NormalCard infoCard = MainStorage.ThisCardMassive[MainStorage.counterCard-1];     //Устанавливаю карточку через номер id
        MainStorage.thisCard = infoCard;

        GameObject newGameCard = Instantiate(gameCard, gameCard.transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;  //Собственно создание
        newGameCard.GetComponent<SpriteRenderer>().sprite = LoadSprite(infoCard, "ProfessionIcon");

        MainStorage.counterCard++;   //Увеличиваю этот номер
    }

    static public void CreatePlayCardOfDied(string diedAspect)
    {
        NormalCard infoCard;
        switch (diedAspect)
        {
            case "money":
                infoCard = new NormalCard(JSONCardReader.GetCard(1, MainStorage.era, "DiedIcon"));
                break;

            case "army":
                infoCard = new NormalCard(JSONCardReader.GetCard(2, MainStorage.era, "DiedCard"));
                break;

            case "religion":
                infoCard = new NormalCard(JSONCardReader.GetCard(3, MainStorage.era, "DiedCard"));
                break;

            case "people":
                infoCard = new NormalCard(JSONCardReader.GetCard(4, MainStorage.era, "DiedCard"));
                break;

            default:
                infoCard = new NormalCard(JSONCardReader.GetCard(8, MainStorage.era, "DiedCard"));
                break;
        }
        MainStorage.thisCard = infoCard;
        GameObject newGameCard = Instantiate(gameCard, gameCard.transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;  //Собственно создание
        newGameCard.GetComponent<SpriteRenderer>().sprite = LoadSprite(infoCard, "DiedIcon");
    }

    //Удаление карточки с экрана
    static public void DeletePlayCard()
    {
        Destroy(GameObject.Find("NormalCard(Clone)"));
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
        //MainStorage.maxCountCardOfThisEra = System.IO.Directory.GetFiles(Application.streamingAssetsPath + "\\CardListJSON\\" + era).Length / 2;   //Считаю количество карточек исключая их meta дубли
        NormalCard[] CardMassive = new NormalCard[MainStorage.maxCountCardOfThisEra];
        for (int i = 1; i <= MainStorage.maxCountCardOfThisEra; i++)
        {                               //Считываю все карточки и заношу уже как нормальные в массив
            CardMassive[i - 1] = new NormalCard(JSONCardReader.GetCard(i, era, "BaseCard"));
        }

        //Перемешка массива
        for(int i = CardMassive.Length - 1; i >= 1; i--)
        {
            int j = new System.Random().Next() % (i + 1);
            NormalCard tmp = CardMassive[j];
            CardMassive[j] = CardMassive[i];
            CardMassive[i] = tmp;
        }

        return CardMassive;
    }
}

    

