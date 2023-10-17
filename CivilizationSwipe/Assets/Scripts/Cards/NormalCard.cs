using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;
using static JSONCardReader;
using Unity.VisualScripting;

public class NormalCard : BaseCard       //Это уже карточка со значениями и методами
{
    public int MoneyL;
    public int ArmyL;
    public int ReligionL;
    public int PeopleEffectL;

    public int MoneyR;
    public int ArmyR;
    public int ReligionR;
    public int PeopleEffectR;

    public string ImageHero;

    public NormalCard(ReadingCard ReadCard)    //Конструктор карты, создающий новую из Считываемой JSON карты
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

    //Устанавливаю этой карте значение в зависимосте от переданной карточки
    public void DownloadNormalCard(NormalCard ReadCard)
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

    //Когда объект с этим скриптом создается, то устанавливаю ей значения в зависимости от текущей карточки из массива и эры
    private void OnEnable()
    {   
        DownloadNormalCard(MainStorage.thisCard);
    }
}
