using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows;
using static JSONController;

public class CardConstructor : MonoBehaviour
{
    public GameObject gameCard;
    

    public NormalCard[] CardMassive;          //����� ������ �������� ������ ���
    public static NormalCard[] CardMassSet(string era)          //������� ������ �������� ������ ���
    {
        int coutCard = System.IO.Directory.GetFiles(Application.streamingAssetsPath + "\\CardListJSON\\" + era).Length / 2;   //������ ���������� �������� �������� �� meta �����
        NormalCard[] CardMassive = new NormalCard[coutCard];
        for (int i = 1; i <= coutCard; i++)
        {                               //�������� ��� �������� � ������ ��� ��� ���������� � ������
            CardMassive[i - 1] = new NormalCard(JSONController.GetCard(i, era));  //����� ���� ����������
        }
        return CardMassive;
    }

    public void CreatePlayCard() //�������� �������� ��� �������� �������
    {
        //CardMassive = CardMassSet(era);
        NormalCard infoCard = CardMassive[MainStorage.counterCard] as NormalCard;     //������������ �������� ����� ����� id
        MainStorage.counterCard++;   //���������� ���� �����

        GameObject newGameCard = Instantiate(gameCard, new Vector2(0, -0.2f), Quaternion.Euler(0, 0, 0)) as GameObject;  //���������� ��������
        newGameCard.GetComponent<SpriteRenderer>().sprite = LoadSprite(infoCard);
    }

    private Sprite LoadSprite(NormalCard infoCard)
    {
        return Resources.Load<Sprite>(infoCard.Era + "/ProfessionIcon/" + infoCard.Image);       //�������� ������� �� ��������
    }
    

    void Start()
    {
        CardMassive = CardMassSet(MainStorage.era);   //������������ �������� ������� � ����������, ������ ���� � ����� ���������� � ����

        //CreatePlayCard();
       // CreatePlayCard();
    }
}

    

