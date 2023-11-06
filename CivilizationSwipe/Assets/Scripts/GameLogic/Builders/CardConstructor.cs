using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows;

public class CardConstructor : MonoBehaviour
{
    public static GameObject gameCard;

    //�������� �������� ��� �������� �������
    static public void CreatePlayCardOfBase() 
    {
        NormalCard infoCard = MainStorage.ThisCardMassive[MainStorage.counterCard-1];     //������������ �������� ����� ����� id
        MainStorage.thisCard = infoCard;

        GameObject newGameCard = Instantiate(gameCard, gameCard.transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;  //���������� ��������
        newGameCard.GetComponent<SpriteRenderer>().sprite = LoadSprite(infoCard, "ProfessionIcon");

        MainStorage.counterCard++;   //���������� ���� �����
        MainStorage.thisGameCard = newGameCard;
    }

    static public void CreatePlayCardOfDied(string diedAspect)
    {
        NormalCard infoCard;
        switch (diedAspect)
        {
            case "money":
                infoCard = new NormalCard(JSONCardReader.GetCard("money", MainStorage.era, "DiedCard"));
                break;

            case "army":
                infoCard = new NormalCard(JSONCardReader.GetCard("army", MainStorage.era, "DiedCard"));
                break;

            case "religion":
                infoCard = new NormalCard(JSONCardReader.GetCard("religion", MainStorage.era, "DiedCard"));
                break;

            case "people":
                infoCard = new NormalCard(JSONCardReader.GetCard("people", MainStorage.era, "DiedCard"));
                break;

            default:
                infoCard = new NormalCard(JSONCardReader.GetCard(8, MainStorage.era, "DiedCard"));
                break;
        }
        MainStorage.thisCard = infoCard;
        GameObject newGameCard = Instantiate(gameCard, gameCard.transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;  //���������� ��������
        newGameCard.GetComponent<SpriteRenderer>().sprite = LoadSprite(infoCard, "DiedIcon");
        MainStorage.thisGameCard = newGameCard;
    }

    //�������� �������� � ������
    static public void DeletePlayCard()
    {
        Destroy(GameObject.Find("NormalCard(Clone)"));
        MainStorage.thisCard = null;
    }

    //�������� ������� �������� �� ��������
    static private Sprite LoadSprite(NormalCard infoCard, string typeCard)
    {
        return Resources.Load<Sprite>(infoCard.Era + "/" + typeCard + "/" + infoCard.Image);       
    }

    //�������� ������� �������� ��������� ���
    public static NormalCard[] CardMassSet(string era)
    {
        int countAllCard = MainStorage.maxCountCardOfThisEra + MainStorage.maxCountCardOfStartEra;
        //MainStorage.maxCountCardOfThisEra = System.IO.Directory.GetFiles(Application.streamingAssetsPath + "\\CardListJSON\\" + era).Length / 2;   //������ ���������� �������� �������� �� meta �����
        NormalCard[] CardMassive = new NormalCard[countAllCard];
        NormalCard[] CardStart = new NormalCard[MainStorage.maxCountCardOfStartEra];
        NormalCard[] CardBase = new NormalCard[MainStorage.maxCountCardOfThisEra];

        for (int i = 0; i < MainStorage.maxCountCardOfStartEra; i++)
        {                               //�������� ��� �������� � ������ ��� ��� ���������� � ������
            CardStart[i] = new NormalCard(JSONCardReader.GetCard(i+1, era, "StartCard"));
        }

        for (int i = 0; i < MainStorage.maxCountCardOfThisEra; i++)
        {                               //�������� ��� �������� � ������ ��� ��� ���������� � ������
            CardBase[i] = new NormalCard(JSONCardReader.GetCard(i+1, era, "BaseCard"));
        }

        

        //��������� �������
        for (int g = CardBase.Length - 1; g >= 1; g--)
        {
            int j = new System.Random().Next() % (g + 1);
            NormalCard tmp = CardBase[j];
            CardBase[j] = CardBase[g];
            CardBase[g] = tmp;
        }

        int f = 0;
        for(; f < MainStorage.maxCountCardOfStartEra; f++)
        {
            CardMassive[f] = CardStart[f];
        }

        for (int i = 0; i < MainStorage.maxCountCardOfThisEra; f++, i++)
        {
            CardMassive[f] = CardBase[i];
        }


        return CardMassive;
    }
}

    

