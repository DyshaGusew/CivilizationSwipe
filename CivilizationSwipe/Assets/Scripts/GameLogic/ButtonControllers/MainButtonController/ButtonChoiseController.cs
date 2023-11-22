using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//���������� �������������� � �������� ������� (������� ������ ��� �����)
public class ButtonControle : MonoBehaviour
{
    //������ ������� ���������
    public GameObject gameCard;

    //�������� ��� �������
    public void ButClick()
    {
        //� ����������� �� ����� ������(������ ��� ��� �����) ��������������� ������ ������� ������� ��� �� ����� (���� +5 ����� ����� �������, -2 ������)
        if (name == "ButtonLeft")
        {
            AspectSetter.AspectLeftSolution();
        }

        else if(name == "ButtonRight")
        {
            AspectSetter.AspectRightSolution();
        }

        //������� ��������
        CardConstructor.DeletePlayCard();

        //�������� ����� ������� �� ������
        MainGameController.ControleAfterBut();

        ButNotMove();
        ButMove();
    }

    //�������� ��� ��������� �� ������
    public void ButMove()
    {
        //� ����������� �� ���� �� ����� ������ ������ �������������� ������ ������� � ������������� ����� �������
        if (name == "ButtonLeft")
        {
            TextSetterView.SetTextLeft();
            LightMarkerMove.LightMarker("ButtonLeft");
        }

        else if (name == "ButtonRight")
        {
            TextSetterView.SetTextRight();
            LightMarkerMove.LightMarker("ButtonRight");
        }
    }

    //���� �� �������� �� ������ �� ��� ���������
    public void ButNotMove()
    {
        TextSetterView.NullTextRightLeft();
        LightMarkerMove.LightMarkerNotMove();
    }
}
