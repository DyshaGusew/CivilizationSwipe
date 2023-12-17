using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Control of the display of the background of the game
//and the style of the aspects
public class FoneAspectSetter : MonoBehaviour
{
    //Setting the background
    static public void FoneSet()
    {
        GameObject.Find("Background").GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Fones/" + MainStorage.era);
    }

    //Setting aspects depending on the transmitted era
    static public void AspecSet()
    {
        //I set the aspects themselves (their type)
        GameObject.Find("Aspects").GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Aspects/" + MainStorage.era);

        //Setting the color of the top line
        switch (MainStorage.era)
        {
            //Each era has its own color
            case "Tribe":
                Color color = new Color(0.3803922f, 0.2156863f, 0.09019608f);
                GameObject.Find("UpLine").GetComponent<SpriteRenderer>().color = color;
                break;

            case "MiddleAges":
                Color color1 = new Color(0.4f, 0.4f, 0.4f);
                GameObject.Find("UpLine").GetComponent<SpriteRenderer>().color = color1;
                break;

            case "NewTime":
                Color color2 = new Color(0.8313726f, 0.7450981f, 0.5647059f);
                GameObject.Find("UpLine").GetComponent<SpriteRenderer>().color = color2;
                break;

            case "ModernTime":
                Color color3 = new Color(0.4156863f, 0.6313726f, 0.3921569f);
                GameObject.Find("UpLine").GetComponent<SpriteRenderer>().color = color3;
                break;

            case "CyberTime":
                Color color4 = new Color(0.6f, 0.6f, 0.6f);
                GameObject.Find("UpLine").GetComponent<SpriteRenderer>().color = color4;
                break;
            default:
                
                break;
        }
    }
}
