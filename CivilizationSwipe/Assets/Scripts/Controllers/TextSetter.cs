using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextSetter : MonoBehaviour
{
    public Text myText;
    public void SetTexEvent(string texName)
    {
        if(myText == null)
        {
            myText.text = "";
        }
        myText.text = texName;
    }

    private void Update()
    {
        SetTexEvent(MainStorage.thisCard.TextEvent);
    }
}
