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
        //Инициализация объектов на сценеzcxv
        TextSetterView.InicializeText();
        LightMarkerMove.InicializeLightMarker();
        CardConstructor.gameCard = Resources.Load<GameObject>("GameModels\\NormalCard");

        //Загрузка всех сохранений при загрузки и установка нового массива карточек
        MainStorage.LoadSaves();
        MainStorage.ThisCardMassive = CardConstructor.CardMassSet(MainStorage.era);
    }

    void Start()
    {
        //Создаю карту и тут же указываю ее текста
        CardConstructor.CreatePlayCard();
        TextSetterView.SetTextEvent(MainStorage.thisCard.TextEvent);
    }

    private void Update()
    {

    }
}
