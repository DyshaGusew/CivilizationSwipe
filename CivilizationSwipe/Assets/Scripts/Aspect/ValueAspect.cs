using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

//������ � ������ ��������� ��������
public class ValueAspect : MonoBehaviour
{
    public GameObject ThisAspect = null;
    public Image image;
    private float Value;

    //� ����������� �� �������� ������ �� ������� ���� ������, ��������������� ��������(Value)
    private float GetValueAspect(string name)
    {
        if (ThisAspect != null)
        {
            switch (ThisAspect.name)
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
        }
        else
        {
            throw new System.Exception("������ �� ������");
        }
        return 0;
    }

    void Update()
    {
        Value = GetValueAspect(ThisAspect.name);
        image.transform.localScale = new Vector3(1, Value/100, 1);
    }
}
