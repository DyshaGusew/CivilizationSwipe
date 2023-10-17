using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows;

public class AspectSetter : MonoBehaviour
{
    static public void AspectLeftSolution()
    {
        MainStorage.army += MainStorage.thisCard.ArmyL;
        MainStorage.money += MainStorage.thisCard.MoneyL;
        MainStorage.religion += MainStorage.thisCard.ReligionL;
        MainStorage.people += MainStorage.thisCard.PeopleEffectL;
    }

    static public void AspectRightSolution()
    {
        MainStorage.army += MainStorage.thisCard.ArmyR;
        MainStorage.money += MainStorage.thisCard.MoneyR;
        MainStorage.religion += MainStorage.thisCard.ReligionR;
        MainStorage.people += MainStorage.thisCard.PeopleEffectR;
    }
}