using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows;
using static JSONController;

public class CardConstructor : MonoBehaviour
{
    public GameObject gameCard;

    public static int countCard = 0;     //Обший счетчик карточек             //Это должно быть в скрипте отвечающем за информацию о игре
    public static string era = "Tribe";

    public NormalCard[] CardMassive;          //Общий массив карточек данной эры
    public static NormalCard[] CardMassSet(string era)          //Получаю массив карточек данной эры
    {
        int coutCard = System.IO.Directory.GetFiles(Application.streamingAssetsPath + "\\CardListJSON\\" + era).Length / 2;   //Считаю количество карточек исключая их meta дубли
        NormalCard[] CardMassive = new NormalCard[coutCard];
        for (int i = 1; i <= coutCard; i++)
        {                               //Считываю все карточки и заношу уже как нормальные в массив
            CardMassive[i - 1] = new NormalCard(JSONController.GetCard(i, era));  //Потом надо перемешать
        }
        return CardMassive;
    }

    public void CreatePlayCard() //Создание карточки как игрового объекта
    {
        //CardMassive = CardMassSet(era);
        NormalCard infoCard = CardMassive[countCard] as NormalCard;     //Устонавливаю карточку через номер id
        countCard++;   //Увеличиваю этот номер

        GameObject newGameCard = Instantiate(gameCard, new Vector2(0, -0.2f), Quaternion.Euler(0, 0, 0)) as GameObject;  //Собственно создание
        newGameCard.GetComponent<SpriteRenderer>().sprite = LoadSprite(infoCard);
    }

    private Sprite LoadSprite(NormalCard infoCard)
    {
        return Resources.Load<Sprite>(infoCard.Era + "/ProfessionIcon/" + infoCard.Image);       //Загрузка спрайта из ресурсов
    }
    

    void Start()
    {
        CardMassive = CardMassSet(era);   //Устанавливаю значение массива с карточками, должно быть в общей информации о игре

        CreatePlayCard();
        CreatePlayCard();
    }
}

    

