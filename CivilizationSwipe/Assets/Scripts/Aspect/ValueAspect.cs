using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class ValueAspect : MonoBehaviour
{
    public GameObject ThisAspect;
    public float Value;
    private Vector2 Position;

    //В зависимости от названия ассета на котором этот скрипт, устанавливается значение(Value)
    private float GetValueAspect(string name)
    {
        if(ThisAspect != null)
        {
            switch (ThisAspect.name)
            {
                case "Деньги":
                    return MainStorage.money;
                case "Военная мощь":
                    return MainStorage.army;
                case "Религия":
                    return MainStorage.religion;
                case "Люди":
                    return MainStorage.people;
            }
        }
        else
        {
            throw new System.Exception("Объект не указан");
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
