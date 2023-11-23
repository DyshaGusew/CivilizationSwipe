using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Контроллер взаимодействия с кнопками решения (которые правое или левое)
public class ButtonControle : MonoBehaviour
{
    //Модель игровой карточкой
    public GameObject gameCard;

    //Действие при нажатии
    public void ButClick()
    {
        //В зависимости от имени кнопки(правая она или левая) устанавливаются правые аспекты решения или же левые (типо +5 денег левое решение, -2 правое)
        if (name == "ButtonLeft")
        {
            AspectSetter.AspectLeftSolution();
        }

        else if(name == "ButtonRight")
        {
            AspectSetter.AspectRightSolution();
        }

        //Удаляем карточку
        CardConstructor.DeletePlayCard();

        //Действие после нажатии на кнопку
        MainGameController.ControleAfterBut();

        ButNotMove();
        ButMove();
    }

    //Действия при наведении на кнопку
    public void ButMove()
    {
        //В зависимость от того на какую кнопку навели подсвечиваются нужные аспекты и высвечивается текст решения
        if (name == "ButtonLeft")
        {
            TextSetterView.SetTextLeft();
            LightMarkerMove.LightMarker("ButtonLeft");
        }

        else if (name == "ButtonRight")
        {
            TextSetterView.SetTextRight();
            LightMarkerMove.LightMarker("ButtonRight");
        }
    }

    //Если не наводять на кнопку то все убирается
    public void ButNotMove()
    {
        TextSetterView.NullTextRightLeft();
        LightMarkerMove.LightMarkerNotMove();
    }
}
