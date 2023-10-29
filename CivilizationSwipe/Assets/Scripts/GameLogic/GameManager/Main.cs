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
        AspectGreenRed.AspectLightSol(0, 0, 0, 0);
    }

    void OnApplicationQuit()
    {
        if (MainStorage.Money > 0 && MainStorage.Army > 0 && MainStorage.Religion > 0 && MainStorage.People > 0)
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
