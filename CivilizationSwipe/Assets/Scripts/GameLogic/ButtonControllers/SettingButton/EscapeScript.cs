using UnityEngine;

//Exit the game by pressing the key
public class EscapeScript : MonoBehaviour
{
    public GameObject canvasSetting;
    public GameObject warning;
    public AudioSource Sound;

    //Output status variable
    public static bool active = false;
    public GameObject anime;
    void Update()
    {
        //Checking the click every frame
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (active == false)
            {
                active = true;
                Pashalka.counter = 0;
                canvasSetting.SetActive(active);
                warning.SetActive(false);
            }
            else if (active == true)
            {
                active = false;
                canvasSetting.SetActive(active);
                Pashalka.counter = 0;
                anime.SetActive(false);
                warning.SetActive(false);
            }
            Sound.Play();
        }
    }
}