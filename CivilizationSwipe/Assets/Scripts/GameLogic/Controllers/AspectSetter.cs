using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using UnityEngine.Windows;

//Установщик значений аспектам
public class AspectSetter : MonoBehaviour
{
    //Установить при выборе левого решения
    static public void AspectLeftSolution()
    {
        MainStorage.Army += MainStorage.thisCard.ArmyL;
        MainStorage.Money += MainStorage.thisCard.MoneyL;
        MainStorage.Religion += MainStorage.thisCard.ReligionL;
        MainStorage.People += MainStorage.thisCard.PeopleEffectL;
        AspectGreenRed.AspectLightSol(MainStorage.thisCard.ArmyL, MainStorage.thisCard.MoneyL, MainStorage.thisCard.ReligionL, MainStorage.thisCard.PeopleEffectL);
    }

    //Установить при выборе прового решения
    static public void AspectRightSolution()
    {
        MainStorage.Army += MainStorage.thisCard.ArmyR;
        MainStorage.Money += MainStorage.thisCard.MoneyR;
        MainStorage.Religion += MainStorage.thisCard.ReligionR;
        MainStorage.People += MainStorage.thisCard.PeopleEffectR;
        AspectGreenRed.AspectLightSol(MainStorage.thisCard.ArmyR, MainStorage.thisCard.MoneyR, MainStorage.thisCard.ReligionR, MainStorage.thisCard.PeopleEffectR);
    }

    


}