using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//The controller interacts with the solution buttons (which are right or left)
public class ButtonControle : MonoBehaviour
{
    //The model is a game card
    public GameObject gameCard;

    //Click action
    public void ButClick()
    {
        //Depending on the name of the button (right or left),
        //the right aspects of the solution are set or the
        //left ones (like +5 money left solution, -2 right)
        if (name == "ButtonLeft")
        {
            AspectSetter.AspectLeftSolution();
        }

        else if(name == "ButtonRight")
        {
            AspectSetter.AspectRightSolution();
        }

        //Deleting the card
        CardConstructor.DeletePlayCard();

        //Action after clicking on the button
        MainGameController.ControleAfterBut();

        ButNotMove();
        ButMove();
    }

    //Actions when hovering over the button
    public void ButMove()
    {
        //Depending on which button is pointed at, the necessary aspects
        //are highlighted and the text of the decision is highlighted
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

    //If you do not point at the button, then everything is removed
    public void ButNotMove()
    {
        TextSetterView.NullTextRightLeft();
        LightMarkerMove.LightMarkerNotMove();
    }
}
