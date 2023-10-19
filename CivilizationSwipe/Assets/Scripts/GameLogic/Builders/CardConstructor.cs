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
    static public void CreatePlayCard() 
    {
        NormalCard infoCard = MainStorage.ThisCardMassive[MainStorage.counterCard-1];     //Устанавливаю карточку через номер id
        MainStorage.thisCard = infoCard;

        GameObject newGameCard = Instantiate(gameCard, gameCard.transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;  //Собственно создание
        newGameCard.GetComponent<SpriteRenderer>().sprite = LoadSprite(infoCard);

        MainStorage.counterCard++;   //Увеличиваю этот номер
    }

    //Удаление карточки с экрана
    static public void DeletePlayCard()
    {
        Destroy(GameObject.Find("NormalCard(Clone)"));
        MainStorage.thisCard = null;
    }

    //Загрузка спрайта карточки из ресурсов
    static private Sprite LoadSprite(NormalCard infoCard)
    {
        return Resources.Load<Sprite>(infoCard.Era + "/ProfessionIcon/" + infoCard.Image);       
    }

    //Создание массива карточек указанной эры
    public static NormalCard[] CardMassSet(string era)
    {
        //MainStorage.maxCountCardOfThisEra = System.IO.Directory.GetFiles(Application.streamingAssetsPath + "\\CardListJSON\\" + era).Length / 2;   //Считаю количество карточек исключая их meta дубли
        NormalCard[] CardMassive = new NormalCard[MainStorage.maxCountCardOfThisEra];
        for (int i = 1; i <= MainStorage.maxCountCardOfThisEra; i++)
        {                               //Считываю все карточки и заношу уже как нормальные в массив
            CardMassive[i - 1] = new NormalCard(JSONCardReader.GetCard(i, era));
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

    

