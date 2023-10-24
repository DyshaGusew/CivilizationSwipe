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
        CardConstructor.CreatePlayCardOfBase();
        TextSetterView.SetTextEvent(MainStorage.thisCard.TextEvent, MainStorage.thisCard.TextHero);
    }

    private void Update()
    {

    }
    void OnApplicationQuit()
    {
        if (MainStorage.money > 0 && MainStorage.army > 0 && MainStorage.religion > 0 && MainStorage.people > 0)
        {
            MainStorage.Save();
        }
        else
        {
            MainStorage.LoadNormalValue();
            MainStorage.Save();
        }
    }
}
