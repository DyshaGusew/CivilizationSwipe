using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//����� ����� � ���������, ��� �������� ��� ������� ����
public class StarterGame : MonoBehaviour
{
    //�������� ����� ������ ����������� �����
    private void Awake()
    {
        //������������� �������� �� �����
        TextSetterView.InicializeText();
        LightMarkerMove.InicializeLightMarker();
        CardConstructor.gameCardModel = Resources.Load<GameObject>("GameModels\\NormalCard");

        //�������� ���� ���������� � ��������� ������ ������� ��������
        MainStorage.LoadSaves();
        MainStorage.ThisCardMassive = CardConstructor.CardMassSet(MainStorage.era);
    }

    void Start()
    {
        //������ ����� � ��� �� �������� �� ������
        CardConstructor.CreatePlayCardOfBase();
        TextSetterView.SetTextEvent(MainStorage.thisCard.TextEvent, MainStorage.thisCard.TextHero);

        //������������ ��������� ����
        AspectGreenRed.AspectLightSol(0, 0, 0, 0);
        FoneAspectSetter.FoneSet();
        FoneAspectSetter.AspecSet();

        //�������� �������� ���� ����� ������� ������ � ����
        if(MainStorage.learning == 0)
        {
           GameObject.Find("CanvasLearning").GetComponent<LearningController>().StartLerning();
           MainStorage.learning = 1;
        }

        MainStorage.Save();
        GameObject.Find("FoneAudio").GetComponent<AudioController>().SetFoneAudio(MainStorage.era);
    }
    
    //������� ��� ������
    void OnApplicationQuit()
    {
        //���� ��� � ����������� ���������, �� ��������, ����� ������������ ��������� ��������
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
