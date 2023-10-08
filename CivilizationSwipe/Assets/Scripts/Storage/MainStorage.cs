using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//��� ��������� ���� ����� ����������
public class MainStorage : MonoBehaviour
{
    public static float money = 50;         //��� ��� �������� ����� ����������� �� json ����� ��� ��������
    public static float army = 100;
    public static float religion = 80;
    public static float people = 20;

    public static int counterCard = 0;
    public static string era;
    public static NormalCard[] CardMassive;          //����� ������ �������� ������ ���

    //����� ��� �����������
    private void Awake()
    {
        era = "Tribe";        //����� ���� ������ ����������� �� json
        CardMassive = CardMassSet(era);   //������������ �������� ������� � ����������, ������ ���� � ����� ���������� � ����
    }

    //������� ������ �������� ������ ���
    public static NormalCard[] CardMassSet(string era)          
    {
        int coutCard = System.IO.Directory.GetFiles(Application.streamingAssetsPath + "\\CardListJSON\\" + era).Length / 2;   //������ ���������� �������� �������� �� meta �����
        NormalCard[] CardMassive = new NormalCard[coutCard];
        for (int i = 1; i <= coutCard; i++)
        {                               //�������� ��� �������� � ������ ��� ��� ���������� � ������
            CardMassive[i - 1] = new NormalCard(JSONController.GetCard(i, era));  //����� ���� ����������
        }
        return CardMassive;
    }
}
