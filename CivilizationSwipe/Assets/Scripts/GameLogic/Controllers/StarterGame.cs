using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Точка входя в программу, все действия при запуске игры
public class StarterGame : MonoBehaviour
{
    //Загрузка всего должна происходить здесь
    private void Awake()
    {
        //Инициализация объектов на сцене
        TextSetterView.InicializeText();
        LightMarkerMove.InicializeLightMarker();
        CardConstructor.gameCardModel = Resources.Load<GameObject>("GameModels\\NormalCard");

        //Загрузка всех сохранений и установка нового массива карточек
        MainStorage.LoadSaves();
        MainStorage.ThisCardMassive = CardConstructor.CardMassSet(MainStorage.era);
    }

    void Start()
    {
        //Создаю карту и тут же указываю ее текста
        CardConstructor.CreatePlayCardOfBase();
        TextSetterView.SetTextEvent(MainStorage.thisCard.TextEvent, MainStorage.thisCard.TextHero);

        //Устанавливаю окружение игры
        AspectGreenRed.AspectLightSol(0, 0, 0, 0);
        FoneAspectSetter.FoneSet();
        FoneAspectSetter.AspecSet();

        //Открытие обучение если игрок впервые входит в игру
        if(MainStorage.learning == 0)
        {
           GameObject.Find("CanvasLearning").GetComponent<LearningController>().StartLerning();
           MainStorage.learning = 1;
        }

        MainStorage.Save();
        GameObject.Find("FoneAudio").GetComponent<AudioController>().SetFoneAudio(MainStorage.era);
    }
    
    //Условия при выходе
    void OnApplicationQuit()
    {
        //Если все с параметрами нормально, то сохраняю, иначе устанавливаю начальные значения
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
