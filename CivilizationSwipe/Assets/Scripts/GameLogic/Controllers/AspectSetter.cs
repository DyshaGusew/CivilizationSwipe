using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using UnityEngine.Windows;

public class AspectSetter : MonoBehaviour
{
    static public void AspectLeftSolution()
    {
        MainStorage.army += MainStorage.thisCard.ArmyL;
        MainStorage.money += MainStorage.thisCard.MoneyL;
        MainStorage.religion += MainStorage.thisCard.ReligionL;
        MainStorage.people += MainStorage.thisCard.PeopleEffectL;
        AspectGreenRed.AspectLightSol(MainStorage.thisCard.ArmyL, MainStorage.thisCard.MoneyL, MainStorage.thisCard.ReligionL, MainStorage.thisCard.PeopleEffectL);
    }

    static public void AspectRightSolution()
    {
        MainStorage.army += MainStorage.thisCard.ArmyR;
        MainStorage.money += MainStorage.thisCard.MoneyR;
        MainStorage.religion += MainStorage.thisCard.ReligionR;
        MainStorage.people += MainStorage.thisCard.PeopleEffectR;
        AspectGreenRed.AspectLightSol(MainStorage.thisCard.ArmyR, MainStorage.thisCard.MoneyR, MainStorage.thisCard.ReligionR, MainStorage.thisCard.PeopleEffectR);
    }

    


}