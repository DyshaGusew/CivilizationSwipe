using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public GameObject gameCard;

    //�������� ����� ������ ����������� �����
    private void Awake()
    {
        //������������� �������� �� �����
        TextSetterView.InicializeText();
        CardConstructor.gameCard = Resources.Load<GameObject>("GameModels\\NormalCard");

        //�������� ���� ���������� ��� �������� � ��������� ������ ������� ��������
        MainStorage.DownloadSaves();
        MainStorage.ThisCardMassive = CardConstructor.CardMassSet(MainStorage.era);
    }

    void Start()
    {
        //������ ����� � ��� �� �������� �� ������
        CardConstructor.CreatePlayCard();
        TextSetterView.SetTextEvent(MainStorage.thisCard.TextEvent);
    }

    private void Update()
    {
        //������� ���������
        if(MainStorage.money <= 0 || MainStorage.army <= 0 || MainStorage.religion <= 0 || MainStorage.people <= 0) {

        }
    }
}
