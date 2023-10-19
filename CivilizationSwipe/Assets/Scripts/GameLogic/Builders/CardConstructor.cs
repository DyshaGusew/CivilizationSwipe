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
    static public void CreatePlayCard() 
    {
        NormalCard infoCard = MainStorage.ThisCardMassive[MainStorage.counterCard-1];     //������������ �������� ����� ����� id
        MainStorage.thisCard = infoCard;

        GameObject newGameCard = Instantiate(gameCard, gameCard.transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;  //���������� ��������
        newGameCard.GetComponent<SpriteRenderer>().sprite = LoadSprite(infoCard);

        MainStorage.counterCard++;   //���������� ���� �����
    }

    //�������� �������� � ������
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
        //MainStorage.maxCountCardOfThisEra = System.IO.Directory.GetFiles(Application.streamingAssetsPath + "\\CardListJSON\\" + era).Length / 2;   //������ ���������� �������� �������� �� meta �����
        NormalCard[] CardMassive = new NormalCard[MainStorage.maxCountCardOfThisEra];
        for (int i = 1; i <= MainStorage.maxCountCardOfThisEra; i++)
        {                               //�������� ��� �������� � ������ ��� ��� ���������� � ������
            CardMassive[i - 1] = new NormalCard(JSONCardReader.GetCard(i, era));
        }

        //��������� �������
        for(int i = CardMassive.Length - 1; i >= 1; i--)
        {
            int j = new System.Random().Next() % (i + 1);
            NormalCard tmp = CardMassive[j];
            CardMassive[j] = CardMassive[i];
            CardMassive[i] = tmp;
        }

        return CardMassive;
    }
}

    

