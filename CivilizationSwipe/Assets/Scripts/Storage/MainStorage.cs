using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//��� ��������� ���� ����� ����������
public class MainStorage : MonoBehaviour
{
    public static float money = 50;         //��� ��� �������� ����� ����������� �� json ����� ��� ��������
    public static float army = 50;
    public static float religion = 50;
    public static float people = 50;

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


}
