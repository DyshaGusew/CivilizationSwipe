using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�������� ���� ������ ��� ���������
public class OpenWindowWinOrFail : MonoBehaviour
{
    //������ �� ���� ����
    public GameObject gameOverMenu;
    public GameObject gameWinMenu;

    //������� ���� ������
    public void AtiveExitMenu()
    {
        gameOverMenu.SetActive(true);
    }

    //�������� ����� ����
    public void ClickNewGame()
    {
        gameObject.SetActive(false);
    }

    //��������� ���� ������
    public void AtiveWinMenu()
    {
        gameWinMenu.SetActive(true);
    }
}
