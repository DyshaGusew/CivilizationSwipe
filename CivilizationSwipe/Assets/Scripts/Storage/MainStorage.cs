using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//��� ��������� ���� ����� ����������
public class MainStorage : MonoBehaviour
{
    public static float money = 40;         //��� ��� �������� ����� ����������� �� json ����� ��� ��������
    public static float army = 30;
    public static float religion = 20;
    public static float people = 10;

    public static int counterCard = 0;
    public static string era;
    public static NormalCard[] CardMassive;          //����� ������ �������� ������ ���

    public static JSONCardReader.ReadingCard thisCard;

    //����� ��� �����������
    private void Awake()
    {
        era = "Tribe";        //����� ���� ������ ����������� �� json
        CardMassive = CardConstructor.CardMassSet(era);   //������������ �������� ������� � ����������, ������ ���� � ����� ���������� � ����
    }
}
