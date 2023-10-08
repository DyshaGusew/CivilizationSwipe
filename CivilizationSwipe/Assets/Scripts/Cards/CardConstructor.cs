using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows;

public class CardConstructor : MonoBehaviour
{
    public GameObject gameCard;
    
    public void CreatePlayCard() //Создание карточки как игрового объекта
    {
        NormalCard infoCard = MainStorage.CardMassive[MainStorage.counterCard];     //Устонавливаю карточку через номер id
        MainStorage.counterCard++;   //Увеличиваю этот номер

        GameObject newGameCard = Instantiate(gameCard, new Vector2(0, -0.2f), Quaternion.Euler(0, 0, 0)) as GameObject;  //Собственно создание
        newGameCard.GetComponent<SpriteRenderer>().sprite = LoadSprite(infoCard);
    }

    //Загрузка спрайта из ресурсов
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

    

