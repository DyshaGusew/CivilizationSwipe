using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class ValueAspect : MonoBehaviour
{
    public GameObject ThisAspect;
    public float Value;
    private Vector2 Position;

    //� ����������� �� �������� ������ �� ������� ���� ������, ��������������� ��������(Value)
    private float GetValueAspect(string name)
    {
        if(ThisAspect != null)
        {
            switch (ThisAspect.name)
            {
                case "������":
                    return MainStorage.money;
                case "������� ����":
                    return MainStorage.army;
                case "�������":
                    return MainStorage.religion;
                case "����":
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
        ThisAspect.transform.position = new Vector2(Position.x, Position.y-(Value/100));
    }
}
