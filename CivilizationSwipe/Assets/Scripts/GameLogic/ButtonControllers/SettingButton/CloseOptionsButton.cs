using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�������� ���� ��������
public class CloseOptionsButton : MonoBehaviour
{
    public GameObject canvasSetting;
    public void Click()
    {
        canvasSetting.SetActive(false);
        EscapeScript.active = false;
    }
}
