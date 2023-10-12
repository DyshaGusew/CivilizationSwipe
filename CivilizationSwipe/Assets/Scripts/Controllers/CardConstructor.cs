using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows;

public class CardConstructor : MonoBehaviour
{
    //�������� �������� ��� �������� �������
    static public void CreatePlayCard(GameObject gameCard) 
    {
        NormalCard infoCard = MainStorage.CardMassive[MainStorage.counterCard];     //������������ �������� ����� ����� id
        MainStorage.counterCard++;   //���������� ���� �����

        GameObject newGameCard = Instantiate(gameCard, gameCard.transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;  //���������� ��������
        newGameCard.GetComponent<SpriteRenderer>().sprite = LoadSprite(infoCard);
    }

    static public void DeletePlayCard()
    {
        Destroy(GameObject.Find("NormalCard(Clone)"));
        MainStorage.thisCard = null;
    }

    //�������� ������� �������� �� ��������
    static private Sprite LoadSprite(NormalCard infoCard)
    {
        return Resources.Load<Sprite>(infoCard.Era + "/ProfessionIcon/" + infoCard.Image);       
    }


    //�������� ������� �������� ��������� ���
    public static NormalCard[] CardMassSet(string era)
    {
        int coutCard = System.IO.Directory.GetFiles(Application.streamingAssetsPath + "\\CardListJSON\\" + era).Length / 2;   //������ ���������� �������� �������� �� meta �����
        NormalCard[] CardMassive = new NormalCard[coutCard];
        for (int i = 1; i <= coutCard; i++)
        {                               //�������� ��� �������� � ������ ��� ��� ���������� � ������
            CardMassive[i - 1] = new NormalCard(JSONCardReader.GetCard(i, era));  //����� ���� ����������
        }
        return CardMassive;
    }
}

    

