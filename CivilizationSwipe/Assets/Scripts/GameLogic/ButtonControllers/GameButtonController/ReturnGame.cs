using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Soft button to restart the game (for tests)
public class ReturnGame : MonoBehaviour
{
    public void Return()
    {
        PlayerPrefs.DeleteAll();
        MainStorage.LoadNormalValue();
        MainGameController.gameOver = false;

        Destroy(GameObject.Find("NormalCard(Clone)"));
        MainStorage.thisCard = null;

        MainStorage.ThisCardMassive = CardConstructor.CardMassSet(MainStorage.era);
        CardConstructor.CreatePlayCardOfBase();
        TextSetterView.SetTextEvent(MainStorage.thisCard.TextEvent, MainStorage.thisCard.TextHero);
        AspectGreenRed.AspectLightSol(0, 0, 0, 0);

        GameObject.Find("CanvasLearning").GetComponent<LearningController>().StartLerning();
        MainStorage.learning = 1;
        GameObject.Find("FoneAudio").GetComponent<AudioController>().SetFoneAudio(MainStorage.era);
    }

}
