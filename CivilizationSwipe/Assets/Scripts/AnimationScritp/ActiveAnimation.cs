using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ActiveAnimation : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Animator targetAnimator; // ������ �� ��������� Animator, ����������� ��������� ������� �������
    public string parameterName; // �������� ���������� � ���������, �������� ������� ����� ��������

    public bool enterValue; // �������� ���������� ��� ��������� �������
    public bool exitValue; // �������� ���������� ��� ����� �������

    public void OnPointerEnter(PointerEventData eventData)
    {
        // ������������� �������� ���������� ��� ��������� �� ������
        targetAnimator.SetBool(parameterName, enterValue);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // ������������� �������� ���������� ��� ����� � ������
        targetAnimator.SetBool(parameterName, exitValue);
    }
}

