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
        //PlayerPrefs.DeleteAll();
        //Инициализация объектов на сценеzcxv
        TextSetterView.InicializeText();
        LightMarkerMove.InicializeLightMarker();
        CardConstructor.gameCardModel = Resources.Load<GameObject>("GameModels\\NormalCard");

        //Загрузка всех сохранений при загрузки и установка нового массива карточек
        MainStorage.LoadSaves();
        MainStorage.ThisCardMassive = CardConstructor.CardMassSet(MainStorage.era);
    }

    void Start()
    {
        //Создаю карту и тут же указываю ее текста
        CardConstructor.CreatePlayCardOfBase();
        TextSetterView.SetTextEvent(MainStorage.thisCard.TextEvent, MainStorage.thisCard.TextHero);
        AspectGreenRed.AspectLightSol(0, 0, 0, 0);
        FoneAspectSetter.FoneSet();
        FoneAspectSetter.AspecSet();

        if(MainStorage.learning == 0)
        {
           GameObject.Find("CanvasLearning").GetComponent<LearningController>().StartLerning();
           MainStorage.learning = 1;
        }
        MainStorage.Save();

    }

    void OnApplicationQuit()
    {
        if (MainStorage.Money > 0 && MainStorage.Army > 0 && MainStorage.Religion > 0 && MainStorage.People > 0)
        {
            MainStorage.Save();
        }
        else
        {
            MainStorage.LoadNormalValue();
            
            MainStorage.Save();
        }
    }
}
