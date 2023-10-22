using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//��� ��������� ���� ����� ����������
public class MainStorage : MonoBehaviour
{
    //��� ��� �������� ����� ����������� �� json ����� ��� ��������
    public static float money;         
    public static float army;
    public static float religion;
    public static float people;

    public static int counterCard;
    public static int maxCountCardOfThisEra;

    public static string[] eras = {"Tribe", "MiddleAges", "NewTime", "ModernTimes", "CyberTimes"};
    public static string era;

    public static NormalCard[] ThisCardMassive;

    public static NormalCard thisCard;

    //����� ��� ����������� � ���������
    public static void LoadSaves()
    {
        if (PlayerPrefs.HasKey("money"))
        {
            money = PlayerPrefs.GetFloat("money");
            army = PlayerPrefs.GetFloat("army");
            religion = PlayerPrefs.GetFloat("religion");
            people = PlayerPrefs.GetFloat("people");
            counterCard = PlayerPrefs.GetInt("counterCard");
            era = PlayerPrefs.GetString("era");
            maxCountCardOfThisEra = PlayerPrefs.GetInt("maxCountCardOfThisEra");
        }
        else
        {
            LoadNormalValue();
        }
    }

    //��� ����������� � ���������
    public static void Save()
    {
        PlayerPrefs.SetFloat("money", money);
        PlayerPrefs.SetFloat("army", army);
        PlayerPrefs.SetFloat("religion", religion);
        PlayerPrefs.SetFloat("people", people);
        PlayerPrefs.SetString("era", era);
        PlayerPrefs.SetInt("maxCountCardOfThisEra", maxCountCardOfThisEra);

        //�� ����� �������� �������� �� ���������� 1
        if (counterCard != 1)
            PlayerPrefs.SetInt("counterCard", counterCard - 1);  
        else
            PlayerPrefs.SetInt("counterCard", 1);
    }

    public static void LoadNormalValue() 
    {
        money = 50;
        army = 50;
        religion = 50;
        people = 50;
        counterCard = 1;
        era = eras[0];
        maxCountCardOfThisEra = System.IO.Directory.GetFiles(Application.streamingAssetsPath + "\\CardListJSON\\" + era + "\\BaseCard\\", "*.json").Length;
        Save();
    }
}
