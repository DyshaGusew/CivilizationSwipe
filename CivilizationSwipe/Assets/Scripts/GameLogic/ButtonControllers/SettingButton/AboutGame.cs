using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//Кнопка об игре
public class AboutGame : MonoBehaviour
{
    public GameObject Canvas;
    public static bool active = false;
    public void Aboutgame()
    {
        active = true;
        EscapeScript.active = false;
        Canvas.SetActive(true);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (active == true)
            {
                active = false;
                Canvas.SetActive(false);
            }
        }
    }
}
