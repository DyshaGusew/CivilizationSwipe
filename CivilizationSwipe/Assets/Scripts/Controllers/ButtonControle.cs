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

        //Проверка при нажатии на последнюю карточку данной эры ИСПРАВИТЬ
        if(MainStorage.money > 0 && MainStorage.army > 0 && MainStorage.religion > 0 && MainStorage.people > 0)
        {
            if (MainStorage.counterCard != 4)
            {
                CardConstructor.CreatePlayCard();
                TextSetter.SetTextEvent(MainStorage.thisCard.TextEvent);
            }
            else
            {
                MainStorage.era = "MiddleAges";
                MainStorage.counterCard = 1;

                MainStorage.Save();

                MainStorage.CardMassive = CardConstructor.CardMassSet(MainStorage.era);
                CardConstructor.CreatePlayCard();
                TextSetter.SetTextEvent(MainStorage.thisCard.TextEvent);
            }
        }
        else
        {
            //Должна быть менюшка конца игры
            Debug.Log("Вы проиграли");
            MainStorage.money = 50;
            MainStorage.army = 50;
            MainStorage.religion = 50;
            MainStorage.people = 50;
            MainStorage.counterCard = 1;
            MainStorage.era = "Tribe";

            MainStorage.Save();

            MainStorage.CardMassive = CardConstructor.CardMassSet(MainStorage.era);
            CardConstructor.CreatePlayCard();
            TextSetter.SetTextEvent(MainStorage.thisCard.TextEvent);
        }


        ButMove();
    }

    public void ButMove()
    {
        if (name == "ButtonLeft")
        {
            TextSetter.SetTextLeft();
        }

        else if (name == "ButtonRight")
        {
            TextSetter.SetTextRight();
        }
    }

    public void ButNotMove()
    {
        TextSetter.NullTextRightLeft();
    }
}
