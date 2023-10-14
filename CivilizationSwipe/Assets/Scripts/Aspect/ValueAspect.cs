using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

//������ � ������ ��������� ��������
public class ValueAspect : MonoBehaviour
{
    const float smecenie = 1.25f;  //������� �������� ��������
    public GameObject ThisAspect = null;
    public Image image;
    public float Value = 0.5f;
    private Vector2 Position;

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

    void Start()
    {
        Value = GetValueAspect(ThisAspect.name);
        Position = ThisAspect.transform.position;
    }


    void Update()
    {
       //ThisAspect.transform.localScale = new Vector3(2, 2, 2);
        image.transform.localScale = new Vector3(1, Value/100, 1);
    }
}
