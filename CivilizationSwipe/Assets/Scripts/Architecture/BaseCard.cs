using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public abstract class BaseCard : MonoBehaviour
{     
    public abstract void RightSolution();    //Влияние правого и левого решения
    public abstract void LeftSolution();
    public abstract BaseCard CreateCard(int id);      //Создание карточки по id
}


