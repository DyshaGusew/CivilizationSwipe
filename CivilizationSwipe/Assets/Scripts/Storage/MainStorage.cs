using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//��� ��������� ���� ����� ����������
public class MainStorage : MonoBehaviour
{
    public static float money;         //��� ��� �������� ����� ����������� �� json ����� ��� ��������
    public static float army;
    public static float religion;
    public static float people;

    public static int counterCard = 0;
    public static string era;
    public static NormalCard[] CardMassive;          //����� ������ �������� ������ ���

    public static JSONCardReader.ReadingCard thisCard;

    //����� ��� �����������
    public static void WriteSaves()
    {
        era = "Tribe";        //����� ���� ������ ����������� �� json
        CardMassive = CardConstructor.CardMassSet(era);   //������������ �������� ������� � ����������, ������ ���� � ����� ���������� � ����
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
