using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows;

//����� ���������� � ��������� ��� ������� �������
public class CardConstructor : MonoBehaviour
{
    //������� �������� �� �����(������� ���������� ������ � ������� ����������)
    public static GameObject gameCardModel;

    //�������� �������� ��� �������� �������
    static public void CreatePlayCardOfBase() 
    {
        //���� ��������� ����� �������� �� ������� �������� � ������� ��� ������ �������� ��������, �������� � ���������
        NormalCard infoCard = MainStorage.ThisCardMassive[MainStorage.counterCard-1];     //������������ �������� ����� ����� id
        MainStorage.thisCard = infoCard;

        //���������� ��������
        GameObject newGameCard = Instantiate(gameCardModel, gameCardModel.transform.position, Quaternion.Euler(0, 0, 0));  
        newGameCard.GetComponent<SpriteRenderer>().sprite = LoadSprite(infoCard, "ProfessionIcon");

        //���������� ������� � ������ ������� ������� �������� � ���������
        MainStorage.counterCard++;   
        MainStorage.thisGameCard = newGameCard;
    }

    //�������� �������� ������ � ����������� �� ����������� �� ��� �������
    static public void CreatePlayCardOfDied(string diedAspect)
    {
        //� ����������� �� ���� ������ ���� �� �������� ��������
        NormalCard infoCard = diedAspect switch
        {
            "money" => new NormalCard(JSONCardReader.GetCard("money", MainStorage.era, "DiedCard")),
            "army" => new NormalCard(JSONCardReader.GetCard("army", MainStorage.era, "DiedCard")),
            "religion" => new NormalCard(JSONCardReader.GetCard("religion", MainStorage.era, "DiedCard")),
            "people" => new NormalCard(JSONCardReader.GetCard("people", MainStorage.era, "DiedCard")),
            _ => new NormalCard(JSONCardReader.GetCard(7, MainStorage.era, "DiedCard")),
        };

        //������������ ��� �������� � ��������� � ������ �� �����
        MainStorage.thisCard = infoCard;
        GameObject newGameCard = Instantiate(gameCardModel, gameCardModel.transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;  //���������� ��������
        
        newGameCard.GetComponent<SpriteRenderer>().sprite = LoadSprite(infoCard, "DiedIcon");
        MainStorage.thisGameCard = newGameCard;
    }

    //�������� ��������
    static public void DeletePlayCard()
    {
        MainStorage.thisCard = null;
    }

    //�������� ������� �������� �� ��������
    static private Sprite LoadSprite(NormalCard infoCard, string typeCard)
    {
        return Resources.Load<Sprite>("CardSprites/" + infoCard.Era + "/" + typeCard + "/" + infoCard.Image);       
    }

    //�������� ������� �������� ��������� ���
    public static NormalCard[] CardMassSet(string era)
    {
        //������� ����� ���-�� �������� 
        int countAllCard = MainStorage.maxCountCardOfThisEra + MainStorage.maxCountCardOfStartEra + MainStorage.maxCountCardOfEndEra;
        
        //������ ���� ��������
        NormalCard[] CardMassive = new NormalCard[countAllCard];

        //������� ��������� ��������
        NormalCard[] CardStart = new NormalCard[MainStorage.maxCountCardOfStartEra];  //��������� ����� ���
        NormalCard[] CardBase = new NormalCard[MainStorage.maxCountCardOfThisEra];    //������� ����� ���
        NormalCard[] CardEnd = new NormalCard[MainStorage.maxCountCardOfEndEra];      //�������� ����� ���

        //�������� ��� �������� � ������ �� ������� � ���������� �������
        for (int i = 0; i < MainStorage.maxCountCardOfStartEra; i++)
        {                               
            CardStart[i] = new NormalCard(JSONCardReader.GetCard(i+1, era, "StartCard"));
        }

        for (int i = 0; i < MainStorage.maxCountCardOfThisEra; i++)
        {                               
            CardBase[i] = new NormalCard(JSONCardReader.GetCard(i+1, era, "BaseCard"));
        }

        for (int i = 0; i < MainStorage.maxCountCardOfEndEra; i++)
        {                               
            CardEnd[i] = new NormalCard(JSONCardReader.GetCard(i + 1, era, "EndCard"));
        }

        //��������� ������� � ��������� ����������(��� ������ ���� �������� �����������)
        for (int g = CardBase.Length - 1; g >= 1; g--)
        {
            int j = new System.Random().Next() % (g + 1);
            (CardBase[g], CardBase[j]) = (CardBase[j], CardBase[g]);
        }

        //���������� ������ �������
        int f = 0;
        for(; f < MainStorage.maxCountCardOfStartEra; f++)
        {
            CardMassive[f] = CardStart[f];
        }

        for (int i = 0; i < MainStorage.maxCountCardOfThisEra; f++, i++)
        {
            CardMassive[f] = CardBase[i];
        }

        for (int j = 0; j < MainStorage.maxCountCardOfEndEra; f++, j++)
        {
            CardMassive[f] = CardEnd[j];
        }


        return CardMassive;
    }
}