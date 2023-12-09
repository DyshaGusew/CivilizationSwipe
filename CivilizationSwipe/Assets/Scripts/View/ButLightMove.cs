using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Setting the text color of the buttons on hover
public class ButLightMove : MonoBehaviour
{
    public GameObject text;

    //Pointed - the color is darker
    public void MoveOn()
    {
        ColorUtility.TryParseHtmlString("#919191", out Color col1);
        text.GetComponent<Text>().color = col1;
    }

    //Removed - the color is white
    public void MoveOff()
    {
        ColorUtility.TryParseHtmlString("#FFFFFF", out Color col1);
        text.GetComponent<Text>().color = col1;
    }

    //When activated, the color is white
    private void OnEnable()
    {
        MoveOff();    
    }
}
