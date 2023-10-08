using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Это хранилище всей общей информации
public class MainStorage : MonoBehaviour
{
    public static float money = 50;         //Все эти значения будут приниматься из json файла при загрузке
    public static float army = 100;
    public static float religion = 80;
    public static float people = 20;

    public static int counterCard = 0;
    public static string era;
    public static NormalCard[] CardMassive;          //Общий массив карточек данной эры

    //Здесь все загружается
    private void Awake()
    {
        era = "Tribe";        //Здесь онда должна считываться из json
        CardMassive = CardMassSet(era);   //Устанавливаю значение массива с карточками, должно быть в общей информации о игре
    }

    //Получаю массив карточек данной эры
    public static NormalCard[] CardMassSet(string era)          
    {
        int coutCard = System.IO.Directory.GetFiles(Application.streamingAssetsPath + "\\CardListJSON\\" + era).Length / 2;   //Считаю количество карточек исключая их meta дубли
        NormalCard[] CardMassive = new NormalCard[coutCard];
        for (int i = 1; i <= coutCard; i++)
        {                               //Считываю все карточки и заношу уже как нормальные в массив
            CardMassive[i - 1] = new NormalCard(JSONController.GetCard(i, era));  //Потом надо перемешать
        }
        return CardMassive;
    }
}
