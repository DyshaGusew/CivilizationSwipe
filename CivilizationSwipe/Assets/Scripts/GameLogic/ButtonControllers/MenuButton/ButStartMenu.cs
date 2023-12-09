using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//Display and action of the start game menu button
public class ButStartMenu : MonoBehaviour
{
    public GameObject text;
    private bool moveControle = false;
    private bool upLight = false;
    public float timer = 2.5f;

    //Hover methods
    public void MoveOn()
    {
        //The color is darker
        ColorUtility.TryParseHtmlString("#919191", out Color col1);
        text.GetComponent<Text>().color = col1;
        moveControle = true;
    }

    public void MoveOff()
    {
        //The color is lighter
        ColorUtility.TryParseHtmlString("#FFFFFF", out Color col1);
        text.GetComponent<Text>().color = col1;
        moveControle = false;
    }

    //The condition for starting the next scene
    public void OnPlayBut()
    {
        SceneManager.LoadScene(1);
    }

    //There is also a constant flashing of the button
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
