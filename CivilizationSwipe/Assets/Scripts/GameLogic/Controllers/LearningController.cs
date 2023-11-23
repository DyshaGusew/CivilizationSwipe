using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Обучение в игре
public class LearningController : MonoBehaviour
{
    //Все советы и переменная, активно ли обучение в данный момент
    public GameObject top1;
    public GameObject top2;
    public GameObject top3;
    public GameObject top4;
    public GameObject top5;
    public GameObject top6;
    public GameObject top7;
    public GameObject top8;
    private static bool activeLearning;
    
    //Начало обучения
    public void StartLerning()
    {
        CloseAll();
        activeLearning = true;
        top1.SetActive(true);
    }

    //Проверка на активацию обучения и его запуск
    void Update()
    {
        //Проверка нажатийй и переключение карточек обучения
        if (activeLearning)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if(top1.activeSelf)
                {
                    top1.SetActive(false);
                    top2.SetActive(true);
                }
                else if (top2.activeSelf)
                {
                    top2.SetActive(false);
                    top3.SetActive(true);   
                }
                else if (top3.activeSelf)
                {
                    top3.SetActive(false);
                    top4.SetActive(true);
                }
                else if (top4.activeSelf)
                {
                    top4.SetActive(false);
                    top5.SetActive(true);
                }
                else if (top5.activeSelf)
                {
                    top5.SetActive(false);
                    top6.SetActive(true);
                }
                else if (top6.activeSelf)
                {
                    top6.SetActive(false);
                    top7.SetActive(true);
                }
                else if (top7.activeSelf)
                {
                    top7.SetActive(false);
                    top8.SetActive(true);
                }
                else if (top8.activeSelf)
                {
                    top8.SetActive(false);
                }

            }
            if (Input.GetKeyDown(KeyCode.Q))
            {
                if (top1.activeSelf)
                {
                    top1.SetActive(false);
                }
                else if (top2.activeSelf)
                {
                    top2.SetActive(false);
                    top1.SetActive(true);
                }
                else if (top3.activeSelf)
                {
                    top3.SetActive(false);
                    top2.SetActive(true);
                }
                else if (top4.activeSelf)
                {
                    top4.SetActive(false);
                    top3.SetActive(true);
                }
                else if (top5.activeSelf)
                {
                    top5.SetActive(false);
                    top4.SetActive(true);
                }
                else if (top6.activeSelf)
                {
                    top6.SetActive(false);
                    top5.SetActive(true);
                }
                else if (top7.activeSelf)
                {
                    top7.SetActive(false);
                    top6.SetActive(true);
                }
                else if (top8.activeSelf)
                {
                    top8.SetActive(false);
                    top7.SetActive(true);
                }
            }
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                CloseAll();
            }
        }
    }

    //Закрытие всех карточек обучения
    public void CloseAll()
    {
        top1.SetActive(false);
        top2.SetActive(false);
        top3.SetActive(false);
        top4.SetActive(false);
        top5.SetActive(false);
        top6.SetActive(false);
        top7.SetActive(false);
        top8.SetActive(false);
    }
}
