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

        //Инициализация объектов на сцене
        TextSetter.InicializeText();
        CardConstructor.gameCard = Resources.Load<GameObject>("NormalCard");
        //Загрузка всех сохранений при загрузки
        MainStorage.DownloadSaves();
        MainStorage.CardMassive = CardConstructor.CardMassSet(MainStorage.era);
    }

    void Start()
    {
        //Создаю карту и тут же указываю ее текста
        CardConstructor.CreatePlayCard();
        TextSetter.SetTextEvent(MainStorage.thisCard.TextEvent);
    }

    private void Update()
    {
        //Условие проигрыша
        if(MainStorage.money <= 0 || MainStorage.army <= 0 || MainStorage.religion <= 0 || MainStorage.people <= 0) {

        }
    }
}
