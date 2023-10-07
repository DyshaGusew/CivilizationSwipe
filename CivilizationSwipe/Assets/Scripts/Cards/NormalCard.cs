using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;
using static JSONController;

public class NormalCard : BaseCard       //��� ��� �������� �� ���������� � ��������
{
    public int MoneyL;
    public int ArmyL;
    public int ReligionL;
    public int PeopleEffectL;

    public int MoneyR;
    public int ArmyR;
    public int ReligionR;
    public int PeopleEffectR;

    public NormalCard(ReadingCard ReadCard)    //����������� �����, ��������� ����� �� ����������� JSON �����
    {
        TextEvent = ReadCard.TextEvent; 

        TextLeft = ReadCard.TextLeft;
        MoneyL = ReadCard.MoneyL;
        ArmyL = ReadCard.ArmyL;
        ReligionL = ReadCard.ReligionL;
        PeopleEffectL = ReadCard.PeopleEffectL;

        TextRight = ReadCard.TextRight;
        MoneyR = ReadCard.MoneyR;
        ArmyR = ReadCard.ArmyR;
        ReligionR = ReadCard.ReligionR;
        PeopleEffectR = ReadCard.PeopleEffectR;

        Era = ReadCard.Era;
        Image = ReadCard.ImageHero;
    }

    public void DownloadNormalCard(ReadingCard ReadCard)    //������������ ���� ����� �������� � ����������� �� ���������� �������� JSON
    {
        TextEvent = ReadCard.TextEvent;

        TextLeft = ReadCard.TextLeft;
        MoneyL = ReadCard.MoneyL;
        ArmyL = ReadCard.ArmyL;
        ReligionL = ReadCard.ReligionL;
        PeopleEffectL = ReadCard.PeopleEffectL;

        TextRight = ReadCard.TextRight;
        MoneyR = ReadCard.MoneyR;
        ArmyR = ReadCard.ArmyR;
        ReligionR = ReadCard.ReligionR;
        PeopleEffectR = ReadCard.PeopleEffectR;

        Era = ReadCard.Era;
        Image = ReadCard.ImageHero;
    }
    public override void LeftSolution()
    {
        throw new System.NotImplementedException();
    }

    public override void RightSolution()
    {
        throw new System.NotImplementedException();
    }



    private void OnEnable()
    {   //����� ������ � ���� �������� ���������, �� ������������ �� �������� � ����������� �� ������� �������� �� ������� � ���
        DownloadNormalCard(GetCard(MainStorage.counterCard, MainStorage.era));  
    }
}
