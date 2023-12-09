using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//Setting the text color of the buttons on hover
public class ButLightMoveTMP : MonoBehaviour
{
    public TMP_Text text;

    //Pointed - the color is darker
    public void MoveOn()
    {
        ColorUtility.TryParseHtmlString("#919191", out Color col1);
        text.color = col1;
    }

    //Removed - the color is white
    public void MoveOff()
    {
        ColorUtility.TryParseHtmlString("#FFFFFF", out Color col1);
        text.color = col1;
    }

    //When activated, the color is white
    private void OnEnable()
    {
        MoveOff();    
    }
}
