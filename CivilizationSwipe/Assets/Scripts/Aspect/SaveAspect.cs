using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveAspect : MonoBehaviour
{
    public float money;
    public float army;
    public float religion;
    public float people;
    //public MainStorage storage;

    public void Save()
    {
        money = MainStorage.money;
        army = MainStorage.army;
        religion = MainStorage.religion;
        people = MainStorage.people;
        PlayerPrefs.SetFloat("money", money);
        PlayerPrefs.SetFloat("army", army);
        PlayerPrefs.SetFloat("religion", religion);
        PlayerPrefs.SetFloat("people", people);
        Debug.Log("������" + money);
        Debug.Log("�����" + army);
        Debug.Log("�������" + religion);
        Debug.Log("����" + people);
    }
}
