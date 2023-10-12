using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public GameObject gameCard;

    //Загрузка всего должна происходить здесь
    private void Awake()
    {
        Initialize();
        MainStorage.WriteSaves();
    }

    //Инициализирование нужных игровых объектов
    private void Initialize()
    {
        TextSetter.mainEventText = GameObject.Find("EventCardText");
        TextSetter.leftEventText = GameObject.Find("EventLeftText");
        TextSetter.rightEventText = GameObject.Find("EventRightText");
    }

    void Start()
    {
        TextSetter.leftEventText.SetActive(false);
        TextSetter.rightEventText.SetActive(false);

        CardConstructor.CreatePlayCard(gameCard);
        TextSetter.SetTextEvent(MainStorage.thisCard.TextEvent);
    }
}
