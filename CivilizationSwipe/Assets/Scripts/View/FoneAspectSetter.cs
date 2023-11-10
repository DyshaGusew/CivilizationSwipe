using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoneAspectSetter : MonoBehaviour
{
    
    static public void FoneSet()
    {
        GameObject.Find("Background").GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Fones/" + MainStorage.era);

    }

    static public void AspecSet()
    {
        GameObject.Find("Aspects").GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Aspects/" + MainStorage.era);
       
        switch (MainStorage.era)
        {
            case "Tribe":
                Color color = new Color(0.3803922f, 0.2156863f, 0.09019608f);
                GameObject.Find("UpLine").GetComponent<SpriteRenderer>().color = color;
                break;
            case "MiddleAges":
                Color color1 = new Color(0.1843137f, 0.854902f, 0.4509804f);
                GameObject.Find("UpLine").GetComponent<SpriteRenderer>().color = color1;
                break;
            case "NewTime":
                Color color2 = new Color(0.3803922f, 0.2156863f, 0.09019608f);
                GameObject.Find("UpLine").GetComponent<SpriteRenderer>().color = color2;
                break;
            case "ModernTimes":
                Color color3 = new Color(0.3803922f, 0.2156863f, 0.09019608f);
                GameObject.Find("UpLine").GetComponent<SpriteRenderer>().color = color3;
                break;
            default:
                
                break;
        }
    }

}
