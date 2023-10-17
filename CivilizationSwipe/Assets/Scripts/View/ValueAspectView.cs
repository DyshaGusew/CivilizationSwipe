using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

//������ � ������ ��������� ��������
public class ValueAspectView : MonoBehaviour
{
    private float Value;

    //� ����������� �� �������� ������ �� ������� ���� ������, ��������������� ��������(Value)
    private float GetValueAspect(string name)
    {
        switch (name)
        {
            case "AtributMoney":
                return MainStorage.money;
            case "AtributArmy":
                return MainStorage.army;
            case "AtributReligion":
                return MainStorage.religion;
            case "AtributPeople":
                return MainStorage.people;
        }
        return 200;
    }

    void Update()
    {
        Value = GetValueAspect(name);
        GetComponent<Image>().transform.localScale = new Vector3(1, Value/100, 1);
    }
}
