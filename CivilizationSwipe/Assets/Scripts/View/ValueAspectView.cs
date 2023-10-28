using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

//������ � ������ ��������� ��������
public class ValueAspectView : MonoBehaviour
{
    private float Value;
    [SerializeField] private float speed = 0.3f;

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

    private void Start()
    {
        Value = GetValueAspect(name);
        GetComponent<Image>().transform.localScale = new Vector3(1, Value / 100, 1);
    }

    void Update()
    {
        Value = GetValueAspect(name);
        if(GetComponent<Image>().transform.localScale.y < Value / 100)
        {
            GetComponent<Image>().transform.localScale += new Vector3(0, Time.deltaTime* speed, 0);
        }
        if (GetComponent<Image>().transform.localScale.y > Value / 100)
        {
            GetComponent<Image>().transform.localScale -= new Vector3(0, Time.deltaTime * speed, 0);
        }

    }
}
