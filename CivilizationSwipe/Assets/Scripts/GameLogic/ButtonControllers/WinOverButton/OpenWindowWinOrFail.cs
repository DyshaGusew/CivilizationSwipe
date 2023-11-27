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
        Destroy(GameObject.Find("NormalCard(Clone)"));
        MainGameController.NewGameCreate();
        GameObject.Find("FoneAudio").GetComponent<AudioController>().SetFoneAudio(MainStorage.era);
    }

    //��������� ���� ������
    public void AtiveWinMenu()
    {
        gameWinMenu.SetActive(true);
    }
}
