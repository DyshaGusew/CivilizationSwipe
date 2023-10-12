using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Это хранилище всей общей информации
public class MainStorage : MonoBehaviour
{
    public static float money = 40;         //Все эти значения будут приниматься из json файла при загрузке
    public static float army = 30;
    public static float religion = 20;
    public static float people = 10;

    public static int counterCard = 0;
    public static string era;
    public static NormalCard[] CardMassive;          //Общий массив карточек данной эры

    public static JSONCardReader.ReadingCard thisCard;

    //Здесь все загружается
    private void Awake()
    {
        era = "Tribe";        //Здесь онда должна считываться из json
        CardMassive = CardConstructor.CardMassSet(era);   //Устанавливаю значение массива с карточками, должно быть в общей информации о игре
    }
}
