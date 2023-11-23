using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Открытие окна победы или проигрыша
public class OpenWindowWinOrFail : MonoBehaviour
{
    //Ссылка на сами окна
    public GameObject gameOverMenu;
    public GameObject gameWinMenu;

    //Открыть окно выхода
    public void AtiveExitMenu()
    {
        gameOverMenu.SetActive(true);
    }

    //Создание новой игры
    public void ClickNewGame()
    {
        gameObject.SetActive(false);
    }

    //Активация меню победы
    public void AtiveWinMenu()
    {
        gameWinMenu.SetActive(true);
    }
}
