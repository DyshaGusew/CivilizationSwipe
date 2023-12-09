using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Opening a win or loss window
public class OpenWindowWinOrFail : MonoBehaviour
{
    //Link to the windows themselves
    public GameObject gameOverMenu;
    public GameObject gameWinMenu;

    //Open the exit window
    public void AtiveExitMenu()
    {
        gameOverMenu.SetActive(true);
    }

    //Creating a new game
    public void ClickNewGame()
    {
        gameObject.SetActive(false);
        Destroy(GameObject.Find("NormalCard(Clone)"));
        MainGameController.NewGameCreate();
        GameObject.Find("FoneAudio").GetComponent<AudioController>().SetFoneAudio(MainStorage.era);
    }

    //Activating the victory menu
    public void AtiveWinMenu()
    {
        gameWinMenu.SetActive(true);
    }
}
