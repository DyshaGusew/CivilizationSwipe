using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseCard : MonoBehaviour    //Базовый класс от которого наследуются все остальные классы карточек
{
    public string TextEvent;           //Все эти прараметры должны быть в любой карточке

    public string TextLeft;

    public string TextRight;

    public string Era;
    public string Image;
}
