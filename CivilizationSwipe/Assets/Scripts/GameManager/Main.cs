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
        //������������� �������� �� �����zcxv
        TextSetterView.InicializeText();
        LightMarkerMove.InicializeLightMarker();
        CardConstructor.gameCard = Resources.Load<GameObject>("GameModels\\NormalCard");

        //�������� ���� ���������� ��� �������� � ��������� ������ ������� ��������
        MainStorage.LoadSaves();
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

    }
}
