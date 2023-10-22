using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGame : MonoBehaviour
{
    public GameObject gameOverMenu; 
    public void AtiveExitMenu()
    {
        gameOverMenu.SetActive(true);
    }
    public void ClickNewGame()
    {
        gameObject.SetActive(false);
    }
}
