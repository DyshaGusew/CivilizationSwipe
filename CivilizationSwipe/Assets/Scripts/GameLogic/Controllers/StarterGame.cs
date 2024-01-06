using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//The point of entering the program is all actions when starting the game
public class StarterGame : MonoBehaviour
{
    //Everything should be uploaded here
    private void Awake()
    {
        //Initializing objects on the scene
        TextSetterView.InicializeText();
        LightMarkerMove.InicializeLightMarker();
        CardConstructor.gameCardModel = Resources.Load<GameObject>("GameModels\\NormalCard");

        //Downloading all the saves and installing a new array of cards
        MainStorage.LoadSaves();
        MainStorage.ThisCardMassive = CardConstructor.CardMassSet(MainStorage.era);
    }

    void Start()
    {
        //I create a map and immediately specify its text
        CardConstructor.CreatePlayCardOfBase(); //dfs
        TextSetterView.SetTextEvent(MainStorage.thisCard.TextEvent, MainStorage.thisCard.TextHero);

        //Setting up the game environment
        AspectGreenRed.AspectLightSol(0, 0, 0, 0);
        FoneAspectSetter.FoneSet();
        FoneAspectSetter.AspecSet();

        //Opening training if the player enters the game for the first time
        if (MainStorage.learning == 0)
        {
           GameObject.Find("CanvasLearning").GetComponent<LearningController>().StartLerning();
           MainStorage.learning = 1;
        }

        MainStorage.Save();
        GameObject.Find("FoneAudio").GetComponent<AudioController>().SetFoneAudio(MainStorage.era);
        GameObject.Find("Animation_New_Era").GetComponent<Animation_New_Era>().Anim_Start_New_Era();
    }

    //Exit conditions
    void OnApplicationQuit()
    {
        //If everything is fine with the parameters, then I save them, otherwise I set the initial values
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
