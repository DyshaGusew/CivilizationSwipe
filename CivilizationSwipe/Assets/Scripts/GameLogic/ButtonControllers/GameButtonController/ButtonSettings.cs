using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//������ �������� ���� ��������
public class ButtonSettings : MonoBehaviour
{
    public GameObject canvasSetting;
    public GameObject warning;

    //��� ��� ������� ����������� ���� ��������
    public void Click()
    {
        canvasSetting.SetActive(true);
        warning.SetActive(false);
    }
}
