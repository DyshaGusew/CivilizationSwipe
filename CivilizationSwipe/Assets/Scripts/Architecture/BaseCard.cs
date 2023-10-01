using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public abstract class BaseCard : MonoBehaviour
{     
    public abstract void RightSolution();    //������� ������� � ������ �������
    public abstract void LeftSolution();
    public abstract BaseCard CreateCard(int id);      //�������� �������� �� id
}


