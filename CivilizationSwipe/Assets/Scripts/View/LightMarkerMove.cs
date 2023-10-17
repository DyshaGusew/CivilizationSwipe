using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class LightMarkerMove : MonoBehaviour
{
    static public GameObject moneyMarker;
    static public GameObject armyMarker;
    static public GameObject religionMarker;
    static public GameObject peopleMarker;
    public static void LightMarker(string name)
    {
        if(name == "ButtonLeft")
        {
            if (MainStorage.thisCard.ArmyL != 0)
            {
                armyMarker.SetActive(true);
            }
            if (MainStorage.thisCard.MoneyL != 0)
            {
                moneyMarker.SetActive(true);
            }
            if (MainStorage.thisCard.ReligionL != 0)
            {
                religionMarker.SetActive(true);
            }
            if (MainStorage.thisCard.PeopleEffectL != 0)
            {
                peopleMarker.SetActive(true);
            }
        }

        if (name == "ButtonRight")
        {
            if (MainStorage.thisCard.ArmyR != 0)
            {
                armyMarker.SetActive(true);
            }
            if (MainStorage.thisCard.MoneyR != 0)
            {
                moneyMarker.SetActive(true);
            }
            if (MainStorage.thisCard.ReligionR != 0)
            {
                religionMarker.SetActive(true);
            }
            if (MainStorage.thisCard.PeopleEffectR != 0)
            {
                peopleMarker.SetActive(true);
            }
        }
    }
    public static void LightMarkerNotMove()
    {
       armyMarker.SetActive(false);
       moneyMarker.SetActive(false);
       religionMarker.SetActive(false);
       peopleMarker.SetActive(false);
    }

    public static void InicializeLightMarker()
    {
        moneyMarker = GameObject.Find("LightMoney");
        armyMarker = GameObject.Find("LightArmy");
        religionMarker = GameObject.Find("LightReligion");
        peopleMarker = GameObject.Find("LightPeople");

        moneyMarker.SetActive(false);
        armyMarker.SetActive(false);
        religionMarker.SetActive(false);
        peopleMarker.SetActive(false);
    }
}
