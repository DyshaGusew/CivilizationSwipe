using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//Это хранилище всей информации об игре
public class MainStorage : MonoBehaviour
{
    //Текущие значения аспектов 
    private static float money;
    private static float army;
    private static float religion;
    private static float people;

    //Геттеры и сеттеры текущих параметров
    public static float Money
    {
        get { return money; }
        set
        {
            money = value;
            if (money > 100)
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
        set
        {
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
        set
        {
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
        set
        {
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

    //Переменная, хранящая информацию о прохождении первого обучения
    public static int learning = 0;    
    
    //Счетчик карт данной эры и блоки количества карт определенной эры
    public static int counterCard;
    public static int maxCountCardOfThisEra;
    public static int maxCountCardOfStartEra;
    public static int maxCountCardOfEndEra;

    //Список всех эр и текущая эра
    readonly public static string[] eras = {"Tribe", "MiddleAges", "NewTime", "ModernTime", "CyberTime", "EndGame"};
    public static string era;

    //Массив всех карт данной эры
    public static NormalCard[] ThisCardMassive;

    //Текущая игровая карточка и обычная карточка
    public static GameObject thisGameCard;
    public static NormalCard thisCard;

    //Здесь все загружается из хранилища (которое внутри юнити) 
    public static void LoadSaves()
    { 
        //Если что-либо не сохранено в хранилище(то есть не было первого запуска игры), то устанавливаем начальные значения
        if (PlayerPrefs.HasKey("money") && PlayerPrefs.HasKey("counterCard") && PlayerPrefs.HasKey("era") && PlayerPrefs.HasKey("maxCountCardOfThisEra") && PlayerPrefs.HasKey("maxCountCardOfStartEra") && PlayerPrefs.HasKey("learning") && PlayerPrefs.HasKey("maxCountCardOfEndEra"))
        {
            Money = PlayerPrefs.GetFloat("money");
            Army = PlayerPrefs.GetFloat("army");
            Religion = PlayerPrefs.GetFloat("religion");
            People = PlayerPrefs.GetFloat("people");
            counterCard = PlayerPrefs.GetInt("counterCard");
            era = PlayerPrefs.GetString("era");
            maxCountCardOfThisEra = PlayerPrefs.GetInt("maxCountCardOfThisEra");
            maxCountCardOfStartEra = PlayerPrefs.GetInt("maxCountCardOfStartEra");
            maxCountCardOfEndEra = PlayerPrefs.GetInt("maxCountCardOfEndEra");

            learning = PlayerPrefs.GetInt("learning");
        }
        else
        {
            LoadNormalValue();
            GameObject.Find("FoneAudio").GetComponent<AudioController>().SetFoneAudio(MainStorage.era);
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
        PlayerPrefs.SetInt("maxCountCardOfEndEra", maxCountCardOfEndEra);
        PlayerPrefs.SetInt("learning", learning);

        //Тк после создания карточки он прибавляет 1
        if (counterCard != 1)
            PlayerPrefs.SetInt("counterCard", counterCard - 1);  
        else
            PlayerPrefs.SetInt("counterCard", 1);
    }

    //Установка начальных значений в это хранилище карточек
    public static void LoadNormalValue() 
    {
        Money = 2;
        Army = 2;
        Religion = 2;
        People = 2;
        counterCard = 1;
        era = eras[0];
        maxCountCardOfThisEra = System.IO.Directory.GetFiles(Application.streamingAssetsPath + "\\CardListJSON\\" + era + "\\BaseCard\\", "*.json").Length;
        maxCountCardOfStartEra = System.IO.Directory.GetFiles(Application.streamingAssetsPath + "\\CardListJSON\\" + era + "\\StartCard\\", "*.json").Length;
        maxCountCardOfEndEra = System.IO.Directory.GetFiles(Application.streamingAssetsPath + "\\CardListJSON\\" + era + "\\EndCard\\", "*.json").Length;
        learning = 0;
        FoneAspectSetter.FoneSet();
        FoneAspectSetter.AspecSet();
        

        Save();
    }
}
