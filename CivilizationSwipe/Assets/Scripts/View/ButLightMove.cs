using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//��������� ����� ������ ������ ��� ���������
public class ButLightMove : MonoBehaviour
{
    public GameObject text;

    //����� - ���� ������
    public void MoveOn()
    {
        ColorUtility.TryParseHtmlString("#919191", out Color col1);
        text.GetComponent<Text>().color = col1;
    }

    //����� - ���� �����
    public void MoveOff()
    {
        ColorUtility.TryParseHtmlString("#FFFFFF", out Color col1);
        text.GetComponent<Text>().color = col1;
    }

    //��� ��������� ���� �����
    private void OnEnable()
    {
        MoveOff();    
    }
}
