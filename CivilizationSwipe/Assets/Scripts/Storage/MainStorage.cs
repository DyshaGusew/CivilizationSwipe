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
    public static string era = "Tribe";

    public GameObject Money;
    public GameObject Army;
    public GameObject Religion;
    public GameObject People;

    private void Start()
    {
        money = 100;
    }
}
