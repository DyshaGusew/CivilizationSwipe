using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows;

public class CardConstructor : MonoBehaviour
{
    public GameObject gameCard;
    
    public void CreatePlayCard() //�������� �������� ��� �������� �������
    {
        NormalCard infoCard = MainStorage.CardMassive[MainStorage.counterCard];     //������������ �������� ����� ����� id
        MainStorage.counterCard++;   //���������� ���� �����

        GameObject newGameCard = Instantiate(gameCard, new Vector2(0, -0.2f), Quaternion.Euler(0, 0, 0)) as GameObject;  //���������� ��������
        newGameCard.GetComponent<SpriteRenderer>().sprite = LoadSprite(infoCard);
    }

    //�������� ������� �� ��������
    private Sprite LoadSprite(NormalCard infoCard)
    {
        return Resources.Load<Sprite>(infoCard.Era + "/ProfessionIcon/" + infoCard.Image);       
    }
    

    void Start()
    {
        CreatePlayCard();
        CreatePlayCard();
        CreatePlayCard();
    }
}

    

