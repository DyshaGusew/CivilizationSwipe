using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//Это хранилище всей общей информации
public class MainStorage : MonoBehaviour
{
    //Все эти значения будут приниматься из json файла при загрузке
    private static float money;
    private static float army;
    private static float religion;
    private static float people;
    public static int learning = 0;    //Переменная, хранящая информацию о прохождении первого обучения
    public static GameObject thisGameCard;
    public static float Money
    {
        get { return money; }
        set { 
            money = value; 
            if(money > 100)
            {
                money = 100;
            }
            if (money <= 1)
            {
                money = 0;
            }

        }  
    }

    public static float Army
    {
        get { return army; }
        set { 
            army = value;
            if (army > 100)
            {
                army = 100;
            }
            if (army <= 1)
            {
                army = 0;
            }
        }
    }
    public static float People
    {
        get { return people; }
        set { 
            people = value;
            if (people > 100)
            {
                people = 100;
            }
            if (people <= 1)
            {
                people = 0;
            }
        }
    }
    public static float Religion
    {
        get { return religion; }
        set { 
            religion = value;
            if (religion > 100)
            {
                religion = 100;
            }
            if (religion <= 1)
            {
                religion = 0;
            }
        }
    }

    public static int counterCard;
    public static int maxCountCardOfThisEra;
    public static int maxCountCardOfStartEra;

    public static string[] eras = {"Tribe", "MiddleAges", "NewTime", "ModernTimes", "CyberTimes"};
    public static string era;

    public static NormalCard[] ThisCardMassive;

    public static NormalCard thisCard;

    //Здесь все выгружается в хранилище
    public static void LoadSaves()
    { 
        if (PlayerPrefs.HasKey("money") && PlayerPrefs.HasKey("counterCard") && PlayerPrefs.HasKey("era") && PlayerPrefs.HasKey("maxCountCardOfThisEra") && PlayerPrefs.HasKey("maxCountCardOfStartEra") && PlayerPrefs.HasKey("learning"))
        {
            Money = PlayerPrefs.GetFloat("money");
            Army = PlayerPrefs.GetFloat("army");
            Religion = PlayerPrefs.GetFloat("religion");
            People = PlayerPrefs.GetFloat("people");
            counterCard = PlayerPrefs.GetInt("counterCard");
            era = PlayerPrefs.GetString("era");
            maxCountCardOfThisEra = PlayerPrefs.GetInt("maxCountCardOfThisEra");
            maxCountCardOfStartEra = PlayerPrefs.GetInt("maxCountCardOfStartEra");

            learning = PlayerPrefs.GetInt("learning");
        }
        else
        {
            LoadNormalValue();
        }
    }

    //Все сохраняется в хранилище
    public static void Save()
    {
        PlayerPrefs.SetFloat("money", Money);
        PlayerPrefs.SetFloat("army", Army);
        PlayerPrefs.SetFloat("religion", Religion);
        PlayerPrefs.SetFloat("people", People);
        PlayerPrefs.SetString("era", era);
        PlayerPrefs.SetInt("maxCountCardOfThisEra", maxCountCardOfThisEra);
        PlayerPrefs.SetInt("maxCountCardOfStartEra", maxCountCardOfStartEra);
        PlayerPrefs.SetInt("learning", learning);
        //Тк после создания карточки он прибавляет 1
        if (counterCard != 1)
            PlayerPrefs.SetInt("counterCard", counterCard - 1);  
        else
            PlayerPrefs.SetInt("counterCard", 1);
    }

    public static void LoadNormalValue() 
    {
        Money = 3;
        Army = 3;
        Religion = 3;
        People = 3;
        counterCard = 1;
        era = eras[0];
        maxCountCardOfThisEra = System.IO.Directory.GetFiles(Application.streamingAssetsPath + "\\CardListJSON\\" + era + "\\BaseCard\\", "*.json").Length;
        maxCountCardOfStartEra = System.IO.Directory.GetFiles(Application.streamingAssetsPath + "\\CardListJSON\\" + era + "\\StartCard\\", "*.json").Length;
        learning = 0;
        FoneAspectSetter.FoneSet();
        FoneAspectSetter.AspecSet();

        Save();
    }
}
