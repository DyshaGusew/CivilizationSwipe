using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveAspect : MonoBehaviour
{
    public float money;
    public float army;
    public float religion;
    public float people;
    public string era;
    public int counterCard;
    //public MainStorage storage;

    public void Save()
    {
        money = MainStorage.money;
        army = MainStorage.army;
        religion = MainStorage.religion;
        people = MainStorage.people;
        era = MainStorage.era;  
        counterCard = MainStorage.counterCard;  
        PlayerPrefs.SetFloat("money", money);
        PlayerPrefs.SetFloat("army", army);
        PlayerPrefs.SetFloat("religion", religion);
        PlayerPrefs.SetFloat("people", people);
        PlayerPrefs.SetInt("counterCard", counterCard);
        PlayerPrefs.SetString("era", era);
        //Debug.Log("Деньги" + money);
        //Debug.Log("Армия" + army);
        //Debug.Log("Религия" + religion);
        //Debug.Log("Люди" + people);
    }
}
