using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButLightStartMenu : MonoBehaviour
{
    public GameObject text;
    private bool moveControle = false;
    private bool upLight = false;
    public float timer = 2.5f;
    public void MoveOn()
    {
        Color col1;
        ColorUtility.TryParseHtmlString("#919191", out col1);
        text.GetComponent<Text>().color = col1;
        moveControle = true;
    }

    public void MoveOff()
    {
        Color col1;
        ColorUtility.TryParseHtmlString("#FFFFFF", out col1);
        text.GetComponent<Text>().color = col1;
        moveControle = false;
    }

    public void Update()
    {
        if(!moveControle)
        {
            if (!upLight)
            {
                Color textColor = text.GetComponent<Text>().color;
                text.GetComponent<Text>().color = textColor;

                timer -= Time.deltaTime;
                textColor.a = (1f / 2.5f) * timer;
                text.GetComponent<Text>().color = textColor;
                if (timer <= 0)
                {
                    timer = 0;
                    upLight = true;
                }
            }
            else
            {
                Color textColor = text.GetComponent<Text>().color;
                text.GetComponent<Text>().color = textColor;

                timer += Time.deltaTime;
                textColor.a = (1f / 2.5f) * timer;
                text.GetComponent<Text>().color = textColor;
                if (timer >= 2.5)
                {
                    timer = 2.5f;
                    upLight = false;
                }
            }



        }
    }
}
