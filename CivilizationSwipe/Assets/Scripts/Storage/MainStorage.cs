using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Это хранилище всей общей информации
public class MainStorage : MonoBehaviour
{
    public static float money;         //Все эти значения будут приниматься из json файла при загрузке
    public static float army;
    public static float religion;
    public static float people;

    public static int counterCard = 0;
    public static string era;
    public static NormalCard[] CardMassive;          //Общий массив карточек данной эры

    public static JSONCardReader.ReadingCard thisCard;

    //Здесь все загружается
    public static void WriteSaves()
    {
        era = "Tribe";        //Здесь онда должна считываться из json
        CardMassive = CardConstructor.CardMassSet(era);   //Устанавливаю значение массива с карточками, должно быть в общей информации о игре
    }
    public static void DownloadSaves()
    {
        money = PlayerPrefs.GetFloat("money");
        army = PlayerPrefs.GetFloat("army");
        religion = PlayerPrefs.GetFloat("religion");
        people = PlayerPrefs.GetFloat("people");
        counterCard = PlayerPrefs.GetInt("counterCard");
        era = PlayerPrefs.GetString("era");
    }

}
