using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//��������� ����� ������ ������ ��� ���������
public class ButLightMoveTMP : MonoBehaviour
{
    public TMP_Text text;

    //����� - ���� ������
    public void MoveOn()
    {
        ColorUtility.TryParseHtmlString("#919191", out Color col1);
        text.color = col1;
    }

    //����� - ���� �����
    public void MoveOff()
    {
        ColorUtility.TryParseHtmlString("#FFFFFF", out Color col1);
        text.color = col1;
    }

    //��� ��������� ���� �����
    private void OnEnable()
    {
        MoveOff();    
    }
}
