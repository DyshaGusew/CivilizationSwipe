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

    public static int counterCard = 1;
    public static string era;
    public static NormalCard[] CardMassive;          //Общий массив карточек данной эры

    public static NormalCard thisCard;



    //Здесь все загружается в хранилище
    public static void DownloadSaves()
    {
        money = PlayerPrefs.GetFloat("money");
        army = PlayerPrefs.GetFloat("army");
        religion = PlayerPrefs.GetFloat("religion");
        people = PlayerPrefs.GetFloat("people");
        counterCard = PlayerPrefs.GetInt("counterCard");
        era = PlayerPrefs.GetString("era"); ;
    }

    //Все сохраняется из хранилищя
    public static void Save()
    {
        PlayerPrefs.SetFloat("money", money);
        PlayerPrefs.SetFloat("army", army);
        PlayerPrefs.SetFloat("religion", religion);
        PlayerPrefs.SetFloat("people", people);

        if (counterCard != 1)
        {
            PlayerPrefs.SetInt("counterCard", counterCard - 1);  //Тк после создания карточки он прибавляет 1
        }
        else
        {
            PlayerPrefs.SetInt("counterCard", 1);
        }

        PlayerPrefs.SetString("era", era);
    }

}
