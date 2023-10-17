using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonControle : MonoBehaviour
{
    public GameObject gameCard;

    public void ButClick()
    {
        if (name == "ButtonLeft")
        {
            AspectSetter.AspectLeftSolution();
        }

        else if(name == "ButtonRight")
        {
            AspectSetter.AspectRightSolution();
        }

        CardConstructor.DeletePlayCard();

        //Проверка при нажатии на кнопку
        MainGameController.ControleAfterBut();


        ButMove();
    }

    public void ButMove()
    {
        if (name == "ButtonLeft")
        {
            TextSetterView.SetTextLeft();
        }

        else if (name == "ButtonRight")
        {
            TextSetterView.SetTextRight();
        }
    }

    public void ButNotMove()
    {
        TextSetterView.NullTextRightLeft();
    }
}
