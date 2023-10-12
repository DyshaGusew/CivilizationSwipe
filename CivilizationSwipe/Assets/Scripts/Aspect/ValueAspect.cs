using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

//������ � ������ ��������� ��������
public class ValueAspect : MonoBehaviour
{
    const float smecenie = 1.25f;  //������� �������� ��������
    public GameObject ThisAspect;
    private float Value;
    private Vector2 Position;

    //� ����������� �� �������� ������ �� ������� ���� ������, ��������������� ��������(Value)
    private float GetValueAspect(string name)
    {
        if(ThisAspect != null)
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

    void Start()
    {
        Value = GetValueAspect(ThisAspect.name);
        Position = ThisAspect.transform.position;
    }


    void Update()
    {
        ThisAspect.transform.position = new Vector2(Position.x, Position.y+(GetValueAspect(ThisAspect.name) / 100)*smecenie);
    }
}
