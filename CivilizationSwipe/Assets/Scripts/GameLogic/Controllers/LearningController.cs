using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Learning in the game
public class LearningController : MonoBehaviour
{
    //All tips and variable, is learning active at the moment
    public GameObject top1;
    public GameObject top2;
    public GameObject top3;
    public GameObject top4;
    public GameObject top5;
    public GameObject top6;
    public GameObject top7;
    public GameObject top8;
    public GameObject SoundClick;
    private static bool activeLearning;

    //The beginning of training
    public void StartLerning()
    {
        CloseAll();
        SoundClick.SetActive(true);
        activeLearning = true;
        top1.SetActive(true);
    }

    //Checking for activation of training and its launch
    void Update()
    {
        //Checking clicks and switching training cards
        if (activeLearning)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                SoundClick.GetComponent<AudioSource>().Play();
                if (top1.activeSelf)
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
                    SoundClick.GetComponent<AudioSource>().Play();
                    SoundClick.SetActive(false);//dd
                }

            }
            if (Input.GetKeyDown(KeyCode.Q))
            {
                SoundClick.GetComponent<AudioSource>().Play();
                if (top1.activeSelf)
                {
                    top1.SetActive(false);
                    SoundClick.GetComponent<AudioSource>().Play();
                    SoundClick.SetActive(false);
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
                SoundClick.GetComponent<AudioSource>().Play();
                CloseAll();
            }
        }
    }

    //Closing all study cards
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
        SoundClick.SetActive(false);
    }
}
