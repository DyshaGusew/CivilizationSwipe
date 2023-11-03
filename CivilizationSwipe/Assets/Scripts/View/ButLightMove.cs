using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButLightMove : MonoBehaviour
{
    public GameObject text;
    public void MoveOn()
    {
        Color col1;
        ColorUtility.TryParseHtmlString("#919191", out col1);
        text.GetComponent<Text>().color = col1;
    }

    public void MoveOff()
    {
        Color col1;
        ColorUtility.TryParseHtmlString("#FFFFFF", out col1);
        text.GetComponent<Text>().color = col1;
    }

    private void OnEnable()
    {
        MoveOff();    
    }
}
