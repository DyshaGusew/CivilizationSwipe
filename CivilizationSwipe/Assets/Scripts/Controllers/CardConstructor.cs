using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows;

public class CardConstructor : MonoBehaviour
{
    //Создание карточки как игрового объекта
    static public void CreatePlayCard(GameObject gameCard) 
    {
        NormalCard infoCard = MainStorage.CardMassive[MainStorage.counterCard];     //Устонавливаю карточку через номер id
        MainStorage.counterCard++;   //Увеличиваю этот номер

        GameObject newGameCard = Instantiate(gameCard, gameCard.transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;  //Собственно создание
        newGameCard.GetComponent<SpriteRenderer>().sprite = LoadSprite(infoCard);
    }

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
        int coutCard = System.IO.Directory.GetFiles(Application.streamingAssetsPath + "\\CardListJSON\\" + era).Length / 2;   //Считаю количество карточек исключая их meta дубли
        NormalCard[] CardMassive = new NormalCard[coutCard];
        for (int i = 1; i <= coutCard; i++)
        {                               //Считываю все карточки и заношу уже как нормальные в массив
            CardMassive[i - 1] = new NormalCard(JSONCardReader.GetCard(i, era));  //Потом надо перемешать
        }
        return CardMassive;
    }
}

    

