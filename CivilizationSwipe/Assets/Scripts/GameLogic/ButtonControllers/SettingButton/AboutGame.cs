using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//About the game button
public class AboutGame : MonoBehaviour
{
    public GameObject Canvas;
    public static bool active = false;

    //Activating the window about the game
    public void Aboutgame()
    {
        active = true;
        EscapeScript.active = false;
        Canvas.SetActive(true);
    }

    //Ñlick verification
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
